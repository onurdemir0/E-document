using E_document.Entities;
using NLog.Internal;
using Saxon.Api;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;
using Serializer = Saxon.Api.Serializer;

namespace E_document.FileHelper
{
	public class Transformer
	{
		private static string decodeFrom64(string encodedData)
		{
			byte[] encodedDataAsBytes = System.Convert.FromBase64String(encodedData);
			string returnValue = System.Text.Encoding.UTF8.GetString(encodedDataAsBytes);
			return returnValue;
		}

		public static string EncodeTo64(string toEncode)
		{
			byte[] toEncodeAsBytes = System.Text.Encoding.UTF8.GetBytes(toEncode);
			string returnValue = System.Convert.ToBase64String(toEncodeAsBytes);
			return returnValue;
		}

		public static string TransformXMLToHTML(string inputXmlString, string box, Boolean encoded, bool removePreambles, string barcode, bool showAttachments)
		{
			if (encoded)
				inputXmlString = decodeFrom64(inputXmlString);

			XmlDocument invXml = new XmlDocument { PreserveWhitespace = true };
			try
			{
				invXml.LoadXml(inputXmlString);
			}
			catch (Exception ex)
			{
				throw new Exception("Error on XML data!." + ex.Message, ex.InnerException);
			}

			return getInvoiceHtml(inputXmlString, box, removePreambles, barcode, showAttachments);

		}

		private static string getInvoiceHtml(string inputXmlString, string box, bool removePreambles, string barcode, bool showAttachments)
		{
			string ret = "";
			string _byteOrderMarkUtf8 = Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble());

			XmlDocument invXml = new XmlDocument { PreserveWhitespace = true };
			try
			{
				invXml.LoadXml(inputXmlString);
			}
			catch (Exception ex)
			{
				throw new Exception("Error on XML data!." + ex.Message, ex.InnerException);
			}

			int hasPdfAttacment = 0;
			XmlNode xsltNode = null;

			//SORUN!!
			List<XmlElement> elementlist = XmlHelper.FindNodesIn(invXml.DocumentElement, "AdditionalDocumentReference/Attachment/EmbeddedDocumentBinaryObject");

			for (int i = 0; i < elementlist.Count; i++)
			{
				if (elementlist[i].Attributes["filename"] != null)
					if (elementlist[i].Attributes["filename"].Value.ToLower().Contains(".xslt"))
						xsltNode = elementlist[i];
			}

			//--xslt uzantılı file tanımlı değilse, ilk nodu al
			if (xsltNode == null)
				if (elementlist.Count > 0)
					xsltNode = elementlist[0];

			string htmlPartForAttachment = "";
			if (showAttachments)
			{
				for (int i = 0; i < elementlist.Count; i++)
				{

					if (elementlist[i].Attributes["filename"] != null)
						if (elementlist[i].Attributes["filename"].Value.ToLower().Contains(".pdf"))
							hasPdfAttacment++;
				}

				if (hasPdfAttacment > 0)
				{
					string uuid = XmlHelper.FindNodesIn(invXml.DocumentElement, "UUID")[0].InnerText;
					htmlPartForAttachment = "<div class='attachmentPartHtml' style='font-size:14px;'>**** Bu faturanın eki mevcut, indirmek için <a href='downPdf.aspx?uid=" + uuid + "&box=" + box + "&attpart=1'>tıklayınız.</a> **** <br /></div>";
				}
			}

			if (xsltNode != null)
			{

				string invoiceXslt = decodeFrom64(xsltNode.InnerText);
				bool hp1 = invoiceXslt.StartsWith(_byteOrderMarkUtf8);

				if (hp1 && removePreambles)
				{
					invoiceXslt = invoiceXslt.Remove(0, _byteOrderMarkUtf8.Length);
				}

				///-----yeni
				byte[] xsltBytes = Encoding.UTF8.GetBytes(invoiceXslt);
				bool hp2 = StartsWithByteOrderMark(xsltBytes);
				xsltBytes = RemoveByteOrderMark(xsltBytes);
				invoiceXslt = Encoding.UTF8.GetString(xsltBytes);
				invoiceXslt = invoiceXslt.Replace("xml:space=\"\"", "xml:space=\"default\"");

				XmlDocument xslXml = new XmlDocument { PreserveWhitespace = true };
				try
				{
					xslXml.LoadXml(invoiceXslt);
				}
				catch (Exception ex)
				{
					throw new Exception("Error on XSL data!.hp1:" + hp1.ToString() + ",hp2:" + hp2.ToString() + "." + ex.Message, ex.InnerException);
				}

				string hata = "";

				try
				{
					ret = htmlPartForAttachment + GetTransformBySaxon(inputXmlString, invoiceXslt); ///---- transform by .net XXXX ---- değişti.önce saxon sonra .net 10.02.2017   .net'de stackoverflow hatası yakalanamıyor.                
				}
				catch (Exception ex)
				{
					try
					{
						ret = htmlPartForAttachment + GetAndCacheTransformByDotNet(inputXmlString, invoiceXslt); ///---- transform by .net
					}
					catch (Exception ex2)
					{
						hata = ex.Message;
						if (ex.InnerException != null)
							hata += "." + ex.InnerException.Message;
						hata += " (by3rd).<br/>";

						hata += ex2.Message;
						if (ex2.InnerException != null)
							hata += "." + ex2.InnerException.Message;
						hata += " (native).<br/>";

					}
				}

				//string htmlPartForBarcode = "";
				//if ((!string.IsNullOrEmpty(barcode)) && (hata == ""))
				//{
				//	htmlPartForBarcode = I2of5.GenerateImageHTML(barcode);
				//	int bodyIndex = ret.IndexOf("<body");
				//	if (bodyIndex > -1)
				//	{
				//		int bodyEndIndex = ret.IndexOf(">", bodyIndex + 1);
				//		ret = ret.Insert(bodyEndIndex + 1, htmlPartForBarcode);
				//	}
				//	else
				//		ret = ret.Insert(0, htmlPartForBarcode);
				//}

				if (hata != "")
				{
					hata = "<a>Hatalı xslt!..</a><br/><br/>" + hata;
					return hata;
				}
				else
				{
					return ret;
				}



			}
			else
				return "Xslt içeriği bulunamadı!..";
		}

		private static byte[] RemoveByteOrderMark(byte[] bytes)
		{
			if (!StartsWithByteOrderMark(bytes))
			{
				return bytes;
			}

			byte[] results = new byte[bytes.Length - 3];
			Array.Copy(bytes, 3, results, 0, bytes.Length - 3);

			return results;
		}

		private static bool StartsWithByteOrderMark(byte[] bytes)
		{
			if (bytes == null)
			{
				return false;
			}

			if (bytes.Length < 3)
			{
				return false;
			}

			return
				bytes[0] == 0xEF &&
				bytes[1] == 0xBB &&
				bytes[2] == 0xBF;
		}

		private static string GetTransformBySaxon(string xmlString, string xsltString)
		{
			Processor processor = new Processor();
			XdmNode input = processor.NewDocumentBuilder().Build(XmlReader.Create(new StringReader(xmlString)));

			// Create a transformer for the stylesheet.
			//--- settings
			//XmlReaderSettings set = new XmlReaderSettings();
			//set.DtdProcessing = DtdProcessing.Parse;
			//XmlReader reader = XmlReader.Create(new StringReader(xsltString),set);
			TextReader reader = new StringReader(xsltString);

			XsltTransformer transformer = processor.NewXsltCompiler().Compile(reader).Load();

			// Set the root node of the source document to be the initial context node.
			transformer.InitialContextNode = input;

			// Create a serializer.
			Serializer serializer = new Serializer();
			//serializer.SetOutputWriter(Response.Output); //for screen
			StringWriter results = new StringWriter();
			serializer.SetOutputWriter(results);

			// Transform the source XML to System.out.
			transformer.Run(serializer);

			return results.ToString();
		}

		//private static Dictionary<String, XslCompiledTransform> cachedTransforms = new Dictionary<string, XslCompiledTransform>();
		private static string GetAndCacheTransformByDotNet(String xmlString, String xsltString)
		{
			XslCompiledTransform transform;

			//if (!cachedTransforms.TryGetValue(xslt, out transform))
			//{
			transform = new XslCompiledTransform();
			XmlReaderSettings set = new XmlReaderSettings();
			set.DtdProcessing = DtdProcessing.Parse;

			try
			{
				using (XmlReader reader = XmlReader.Create(new StringReader(xsltString), set))
				{
					transform.Load(reader, new XsltSettings(true, true), new XmlUrlResolver());
				}

			}
			catch (System.StackOverflowException ex)
			{
				throw new Exception("Error on Xslt!." + ex.Message, ex.InnerException);
			}
			catch (Exception ex)
			{
				throw new Exception("Error on Xslt!." + ex.Message, ex.InnerException);
			}

			//    cachedTransforms.Add(xslt, transform);
			//}

			StringWriter results = new StringWriter();
			using (XmlReader reader = XmlReader.Create(new StringReader(xmlString)))
			{
				transform.Transform(reader, null, results);
			}

			return results.ToString();
		}

	}
}
