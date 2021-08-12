<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
	xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"
	xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"
	xmlns:ccts="urn:un:unece:uncefact:documentation:2"
	xmlns:clm54217="urn:un:unece:uncefact:codelist:specification:54217:2001"
	xmlns:clm5639="urn:un:unece:uncefact:codelist:specification:5639:1988"
	xmlns:clm66411="urn:un:unece:uncefact:codelist:specification:66411:2001"
	xmlns:clmIANAMIMEMediaType="urn:un:unece:uncefact:codelist:specification:IANAMIMEMediaType:2003"
	xmlns:fn="http://www.w3.org/2005/xpath-functions" xmlns:link="http://www.xbrl.org/2003/linkbase"
	xmlns:n1="urn:oasis:names:specification:ubl:schema:xsd:Invoice-2"
	xmlns:qdt="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2"
	xmlns:udt="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2"
	xmlns:xbrldi="http://xbrl.org/2006/xbrldi" xmlns:xbrli="http://www.xbrl.org/2003/instance"
	xmlns:xdt="http://www.w3.org/2005/xpath-datatypes" xmlns:xlink="http://www.w3.org/1999/xlink"
	xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:xsd="http://www.w3.org/2001/XMLSchema"
	xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
	exclude-result-prefixes="cac cbc ccts clm54217 clm5639 clm66411 clmIANAMIMEMediaType fn link n1 qdt udt xbrldi xbrli xdt xlink xs xsd xsi">
  <xsl:decimal-format name="european" decimal-separator="," grouping-separator="." NaN=""/>
  <xsl:output version="4.0" method="html" indent="no" encoding="UTF-8"
	doctype-public="-//W3C//DTD HTML 4.01 Transitional//EN"
	doctype-system="http://www.w3.org/TR/html4/loose.dtd"/>
  <xsl:param name="SV_OutputFormat" select="'HTML'"/>

  <xsl:template name="repNL">
    <xsl:param name="pText" select="."/>
    <xsl:if test="not(contains(substring(substring-before(concat($pText,'&#xA;'),'&#xA;'),0,8), '##') and not(contains(substring-before(concat($pText,'&#xA;'),'&#xA;'), '##internetSatis'))) and string-length(substring-before(concat($pText,'&#xA;'),'&#xA;'))>3">
      <xsl:choose>
        <xsl:when test="contains(substring-before(concat($pText,'&#xA;'),'&#xA;'), '##internetSatis')">
          <xsl:copy-of select="substring-after(substring-after(substring-before(concat($pText,'&#xA;'),'&#xA;'),'##'),'#')"/>
          <br />
        </xsl:when>
        <xsl:otherwise>
          <xsl:copy-of select="substring-before(concat($pText,'&#xA;'),'&#xA;')"/>
          <br />
        </xsl:otherwise>
      </xsl:choose>
    </xsl:if>
    <xsl:if test="contains($pText, '&#xA;')">

      <xsl:call-template name="repNL">
        <xsl:with-param name="pText" select=
    "substring-after($pText, '&#xA;')"/>
      </xsl:call-template>
    </xsl:if>
  </xsl:template>

  <xsl:template name="repNL2">
    <xsl:param name="pText" select="."/>
    <xsl:if test="contains(substring(substring-before(concat($pText,'&#xA;'),'&#xA;'),0,8), '##') and not(contains(substring-before(concat($pText,'&#xA;'),'&#xA;'), '##internetSatis'))">
      <tr>
        <th>
          <xsl:copy-of select="substring-after(substring-before(substring-before(concat($pText,'&#xA;'),'&#xA;'),':'),'##')"/>:
        </th>
        <td>
          <xsl:copy-of select="substring-after(substring-before(concat($pText,'&#xA;'),'&#xA;'),':')"/>
        </td>
      </tr>
    </xsl:if>
    <xsl:if test="contains($pText, '&#xA;')">
      <xsl:call-template name="repNL2">
        <xsl:with-param name="pText" select=
    "substring-after($pText, '&#xA;')"/>
      </xsl:call-template>
    </xsl:if>
  </xsl:template>

  <xsl:variable name="XML" select="/"/>
  <xsl:template name="removeLeadingZeros">
    <xsl:param name="originalString"/>
    <xsl:choose>
      <xsl:when test="starts-with($originalString,'0')">
        <xsl:call-template name="removeLeadingZeros">
          <xsl:with-param name="originalString">
            <xsl:value-of select="substring-after($originalString,'0' )"/>
          </xsl:with-param>
        </xsl:call-template>
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select="$originalString"/>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>
  <xsl:template match="/">
    <html>
      <head>
        <title>e-Arşiv Fatura</title>
        <style type="text/css">
          body {
          font-family:Arial, Helvetica, sans-serif;
          }

          .ph {overflow:hidden;max-height:200px;}
          .ph7 {text-align:center;margin-bottom:18px;}
          .ph8 img {margin-bottom: 18px;}
          .ph10 {
          float: left;
          width: 295px;
          margin-top: 14px;
          margin-right: 12px;
          padding: 8px;
          }


          table {font-size:12px;}
          .documentContainer a {pointer-events:none;}
          .documentContainer,
          .documentContainerOuter {
          margin: 0 auto;
          }
          @media screen {
          body {color: #666;}
          .documentContainer {
          max-width: 900px;
          min-width: 850px;
          overflow:hidden;
          text-align: left;
          box-sizing: border-box;
          display:inline-block;
          -webkit-box-shadow: 0 1px 4px rgba(0, 0, 0, 0.3), 0 0 40px rgba(0, 0, 0, 0.1) inset;
          -moz-box-shadow: 0 1px 4px rgba(0, 0, 0, 0.3), 0 0 40px rgba(0, 0, 0, 0.1) inset;
          box-shadow: 0 1px 4px rgba(0, 0, 0, 0.3), 0 0 40px rgba(0, 0, 0, 0.1) inset;
          background-color: white;
          position: relative;
          padding: 20px 20px 20px 28px;
          }

          .documentContainer:before, .documentContainer:after {
          content: "";
          position: absolute;
          z-index: -1;
          -webkit-box-shadow: 0 0 20px rgba(0,0,0,0.8);
          -moz-box-shadow: 0 0 20px rgba(0,0,0,0.8);
          box-shadow: 0 0 20px rgba(0,0,0,0.8);
          top: 50%;
          bottom: 0;
          left: 10px;
          right: 10px;
          -moz-border-radius: 100px / 10px;
          border-radius: 100px / 10px;
          }

          .documentContainer:after {
          right: 10px;
          left: auto;
          -webkit-transform: skew(8deg) rotate(3deg);
          -moz-transform: skew(8deg) rotate(3deg);
          -ms-transform: skew(8deg) rotate(3deg);
          -o-transform: skew(8deg) rotate(3deg);
          transform: skew(8deg) rotate(3deg);
          }
          }

          #ustBolum{
          margin-top: 27px;
          margin-bottom: 15px;
          }
          .efaturaLogo {
          text-align:center;
          }
          .efaturaLogo img{
          width:70px;
          }
          .efaturaLogo h1{
          font-size: 14px;
          line-height: 14px;
          margin: 4px 0 0 0;
          }
          .kutu {vertical-align: top;}

          .kutu table{float:none;}
          .gonderici {
          display: inline-block;
          padding: 8px 8px 8px 0;
          box-sizing: border-box;
          }
          .gonderici .partyName {font-weight:bold;}
          .alici {
          width: 370px;
          padding: 8px 4px 4px 0;
          box-sizing: border-box;
          }
          .alici .customerTitle {font-weight:bold;}
          .alici .kutu { border:1px solid #CCC; background-color:#F4F4F4;}

          #ETTN {
          margin-top: 7px;
          padding: 8px 4px 4px 0;
          }

          #despatchTable .placeHolder.companyLogo img {margin-bottom:18px;}

          #toplamlarContainer {overflow:hidden;}
          .toplamlar {float:right;width: 100%;}
          .toplamlar tr {text-align:right;}
          .toplamlar th {font-weight:normal;text-align:right;}
          .toplamlar table {width:238px;margin-top: 14px;border-spacing:0;}
          .toplamlar table td {font-weight: bold; width:25%; white-space:nowrap;min-width: 55px; vertical-align: top;
          }
          .toplamlar table th,
          .toplamlar table td{
          border-bottom: 1px solid #ccc;
          border-right: 1px solid #ccc;
          border-left: 1px solid #ccc;
          padding:3px;
          }
          .toplamlar table th {white-space:nowrap;border-right: none;}
          .toplamlar table th.is-long-true,
          #malHizmetTablosu > tbody > tr > td .is-long-true {white-space:normal;}
          .toplamlar table tr:first-child th,
          .toplamlar table tr:first-child td{
          border-top:1px solid #ccc;
          }
          .toplamlar table td span {font-weight:normal;font-size: 12px;color: #7C7C7C;}

          tr.payableAmount th:first-child {
          background-color: #f6f6f6;
          }

          tr.payableAmount td {
          background-color: #f6f6f6;
          }

          .toplamlar > div {
          display: inline-block;
          }
          .toplamTablo{
          margin-left: 31px;
          float:right;
          }
          #notlar {
          margin-top: 14px;
          border-top: 1px solid #DDD;
          overflow: hidden;
          padding-top: 8px;
          padding-bottom: 2px;

          }
          #notlar table {border:none;background:none;}
          .clearfix:before,
          .clearfix:after {
          content:"";
          display:table;
          }

          .box{display: inline-block;*display: inline;zoom: 1;width: 33%; box-sizing:border-box; vertical-align: top;}
          #b1{width: 40%;}
          #b2{width: 15%;}
          #b3{width: 45%;}
          #kunye {border-spacing:0;}
          #kunye tr{ border-bottom: 1px dotted #CCC;}
          #kunye td{ border:1px solid #CCC;border-top: none;padding:3px;width: 100%;}
          #kunye th{vertical-align:top;font-weight:bold;padding:3px;white-space: nowrap;border:1px solid #ccc;border-top: none;border-right: none;text-align:left;}
          #kunye tr:first-child td{border-top: 1px solid #ccc;}
          #kunye tr:first-child th{border-top: 1px solid #ccc;}
          #kunye td:nth-child(2) {word-break: break-all;}
          .satirlar {margin-top:20px;}
          #malHizmetTablosu
          {
          width:100%;
          font-family: "Lucida Sans Unicode", "Lucida Grande", Sans-Serif;
          background: #fff;
          border-collapse: collapse;
          text-align: right;
          }
          #malHizmetTablosu > tbody > tr > th
          {
          font-weight: normal;
          padding: 2px;
          text-align:right;
          font-size: 12px;
          color: black;
          padding-left: 3px;
          border-bottom: 2px solid #AAAAAA;
          background-color: #DFDFDF;
          border-right: 1px solid #B8B8B8;
          border-top: 1px solid #C5C5C5;
          padding-right: 5px;
          vertical-align: middle;
          min-height: 35px;
          }
          #malHizmetTablosu > tbody > tr:first-child > th:first-child {border-left: 1px solid #B8B8B8;}
          #malHizmetTablosu > tbody > tr:first-child > th.mhColumn {min-width:72px;}
          #malHizmetTablosu > tbody > th > .thTopTitle {text-align:center;width: 89px;}
          #malHizmetTablosu > tbody > th .thSubTitle {width: 47px; display: inline-block;text-align: right;}
          #malHizmetTablosu > tbody > th .thSubTitle.HF {width:36px;}
          #malHizmetTablosu > tbody > tr > th.alignLeft {text-align:left;width: 50%;}

          #malHizmetTablosu > tbody > tr > td {
          white-space: nowrap;
          font-size: 12px;
          padding-left:3px;
          border-bottom: 1px solid #ccc;
          color: #000;
          border-right: 1px solid #ccc;
          padding-right: 3px;
          text-align:right;
          height:25px;
          }
          #malHizmetTablosu > tbody > tr > td.iskontoOrani {padding-left:0; padding-right:0;}
          #malHizmetTablosu > tbody > tr > td.iskontoOrani td{text-align: center;}
          #malHizmetTablosu > tbody > tr:hover > td {border-right: 1px solid #969696;border-bottom: 1px solid #969696;border-top: 1px solid #969696;}
          #malHizmetTablosu > tbody > tr > td.wrap {white-space:normal;text-align:left;}
          #malHizmetTablosu > tbody > tr > td:first-child,
          #malHizmetTablosu > tbody > tr > th:first-child {border-left: 1px solid #B8B8B8;}

          #malHizmetTablosu > tbody > tr:hover > td
          {
          background-color: #D1D1D1 !important;
          cursor:default;
          }
          #malHizmetTablosu > tbody > tr:nth-child(even) > td {background-color: #FFF}
          #malHizmetTablosu > tbody > tr:nth-child(odd) > td {background-color: #EEE}
          .sumValue {white-space:nowrap;}
          .iskontoOraniHeader,
          .iskontoOraniDegerler {width:100%;border-spacing:0;}
          .iskontoOraniHeader td {border-top: 1px solid #969696;}
          .iskontoOraniHeader td,
          .iskontoOraniDegerler td
          {border-left: 1px solid #969696;}
          .iskontoOraniHeader td:first-child,
          .iskontoOraniDegerler td:first-child {border-left:none;}
          @media print {
          body {color: #000;text-align: left;background:none;background-color:#ffffff;margin:0;}
          .documentContainer {padding:0;min-height: initial;width: 845px !important;}
          #malHizmetTablosu {width: 845px;}
          }


        </style>

      </head>
      <body>
        <div class="documentContainerOuter">
          <div class="documentContainer">
            <xsl:for-each select="$XML">
              <div id="ustBolum">
                <div>
                  <div>

                    <img style="height:45px;weight:90px;margin:20px"  src= "data:image/png;base64,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"/>

                    <img align="right" style="height:45px;weight:90px;margin:20px"  src= "data:image/png;base64,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"/>

                  </div>

                  <hr/>
                </div>
                <br/>
                <br/>
                <br/>
                <div id="b1" class="box">
                  <div id="AccountingSupplierParty" class="gonderici kutu">


                    <xsl:for-each select="n1:Invoice">
                      <xsl:for-each select="cac:AccountingSupplierParty">
                        <xsl:for-each select="cac:Party">
                          <div class="saddres" style="font-size: 15px;">
                            <b>
                              <xsl:if test="cac:PartyLegalEntity/cbc:RegistrationName">
                                <xsl:value-of select="cac:PartyLegalEntity/cbc:RegistrationName"/>,
                              </xsl:if>
                              <xsl:if test="cac:PostalAddress/cbc:StreetName">
                                <xsl:value-of select="cac:PostalAddress/cbc:StreetName"/>,
                              </xsl:if>
                              <xsl:if test="cac:PostalAddress/cbc:AdditionalStreetName">
                                <xsl:value-of select="cac:PostalAddress/cbc:AdditionalStreetName"/> ,
                              </xsl:if>
                              <xsl:if test="cac:PostalAddress/cbc:PostalZone">
                                <xsl:value-of select="cac:PostalAddress/cbc:PostalZone"/>
                              </xsl:if>
                              <xsl:text>&#160;</xsl:text>
                              <xsl:if test="cac:PostalAddress/cbc:CityName">
                                <xsl:value-of select="cac:PostalAddress/cbc:CityName"/> ,
                              </xsl:if>
                              <xsl:if test="cac:PostalAddress/cbc:CountrySubentity">
                                <xsl:value-of select="cac:PostalAddress/cbc:CountrySubentity"/> ,
                              </xsl:if>
                              <xsl:if test="cac:PostalAddress/cac:Country/cbc:IdentificationCode">
                                <xsl:value-of select="cac:PostalAddress/cac:Country/cbc:IdentificationCode"/>
                              </xsl:if>

                            </b>
                          </div>

                        </xsl:for-each>
                      </xsl:for-each>
                      <hr/>
                      <xsl:for-each select="cac:AccountingCustomerParty">
                        <xsl:for-each select="cac:Party">
                          <div class="addres" style="font-size: 15px;">
                            <xsl:if test="cac:PartyLegalEntity/cbc:RegistrationName">
                              <xsl:value-of select="cac:PartyLegalEntity/cbc:RegistrationName"/>
                              <br/>
                            </xsl:if>
                            <xsl:if test="cac:PartyName/cbc:Name">
                              <xsl:value-of select="cac:PartyName/cbc:Name"/>
                              <br/>
                            </xsl:if>
                            <xsl:if test="cac:Contact/cbc:Name">
                              <xsl:value-of select="cac:Contact/cbc:Name"/>
                              <br/>
                            </xsl:if>
                            <xsl:if test="cac:PostalAddress/cbc:StreetName">
                              <xsl:value-of select="cac:PostalAddress/cbc:StreetName"/>
                              <br/>
                            </xsl:if>
                            <xsl:if test="cac:PostalAddress/cbc:AdditionalStreetName">
                              <xsl:value-of select="cac:PostalAddress/cbc:AdditionalStreetName"/>
                              <br/>
                            </xsl:if>
                            <xsl:if test="cac:PostalAddress/cac:AddressLine/cbc:Line">
                              <xsl:value-of select="cac:PostalAddress/cac:AddressLine/cbc:Line"/>
                              <br/>
                            </xsl:if>
                            <xsl:if test="cac:PostalAddress/cbc:PostalZone">
                              <xsl:value-of select="cac:PostalAddress/cbc:PostalZone"/>
                            </xsl:if>
                            <xsl:text>&#160;</xsl:text>
                            <xsl:if test="cac:PostalAddress/cbc:CityName">
                              <xsl:value-of select="cac:PostalAddress/cbc:CityName"/>
                              <br/>
                            </xsl:if>
                            <xsl:if test="cac:PostalAddress/cbc:CountrySubentity">
                              <xsl:value-of select="cac:PostalAddress/cbc:CountrySubentity"/>
                              <br/>
                            </xsl:if>
                            <xsl:if test="cac:PostalAddress/cac:Country/cbc:IdentificationCode">
                              <xsl:value-of select="cac:PostalAddress/cac:Country/cbc:IdentificationCode"/>
                              <br/>
                            </xsl:if>


                          </div>

                        </xsl:for-each>
                      </xsl:for-each>
                    </xsl:for-each>






                  </div>


                </div>
                <div id="b2" class="box" width="100">



                </div>
                <div id="b3" class="box">

                  <br/>

                  <div id="despatchTable">

                    <div style="clear:both;"/>
                    <table id="kunye">
                      <tbody>
                        <xsl:for-each select="n1:Invoice">
                          <xsl:for-each select="cbc:IssueDate">
                            <tr>
                              <th>
                                <xsl:text>Rechnungsdatum:</xsl:text>
                              </th>
                              <td>

                                <xsl:value-of select="substring(.,9,2)"
											/>.<xsl:value-of select="substring(.,6,2)"
											/>.<xsl:value-of select="substring(.,1,4)"/>

                              </td>
                            </tr>
                          </xsl:for-each>
                        </xsl:for-each>
                        <xsl:for-each select="n1:Invoice">
                          <xsl:for-each select="cbc:BuyerReference">
                            <tr>
                              <th>
                                <xsl:text>Leitweg ID:</xsl:text>
                              </th>
                              <td>

                                <xsl:value-of select="."/>

                              </td>
                            </tr>
                          </xsl:for-each>
                        </xsl:for-each>
                        <xsl:for-each select="n1:Invoice">
                          <xsl:for-each select="cbc:ID">
                            <tr>
                              <th>
                                <xsl:text>Bestellnummer:</xsl:text>
                              </th>
                              <td>

                                <xsl:apply-templates/>

                              </td>
                            </tr>
                          </xsl:for-each>
                        </xsl:for-each>
                        <xsl:for-each select="n1:Invoice">
                          <xsl:for-each select="cac:ContractDocumentReference">
                            <tr>
                              <th style="width:105px;">
                                <xsl:text>Vertragsnummer:</xsl:text>
                              </th>
                              <td style="width:110px;">

                                <xsl:value-of select="cbc:ID"/>

                              </td>
                            </tr>
                          </xsl:for-each>
                        </xsl:for-each>
                        <xsl:for-each select="n1:Invoice">
                          <xsl:for-each select="cac:ProjectReference">
                            <tr>
                              <th>
                                <xsl:text>Projektreferenz:</xsl:text>
                              </th>
                              <td>

                                <xsl:value-of select="cbc:ID"/>

                              </td>
                            </tr>
                          </xsl:for-each>
                        </xsl:for-each>
                        <xsl:for-each select="n1:Invoice">
                          <xsl:for-each select="cbc:DueDate">
                            <tr>
                              <th>
                                <xsl:text>Fällig am:</xsl:text>
                              </th>
                              <td>

                                <xsl:value-of select="substring(.,9,2)"/>.<xsl:value-of select="substring(.,6,2)"/>.<xsl:value-of select="substring(.,1,4)"/>

                              </td>
                            </tr>
                          </xsl:for-each>
                        </xsl:for-each>
                        <xsl:for-each select="n1:Invoice">
                          <xsl:for-each select="cbc:DocumentCurrencyCode">
                            <tr>
                              <th>
                                <xsl:text>Währung:</xsl:text>
                              </th>
                              <td>

                                <xsl:value-of select="."/>

                              </td>
                            </tr>
                          </xsl:for-each>
                        </xsl:for-each>
                        <xsl:for-each select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:Name">
                          <tr>
                            <th>
                              <xsl:text>Kontakt Rechnungssteller:</xsl:text>
                            </th>
                            <td>

                              <xsl:value-of select="."/>

                            </td>
                          </tr>
                        </xsl:for-each>
                        <xsl:for-each select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:ElectronicMail">
                          <tr>
                            <th>
                              <xsl:text>E-Mail Rechnungssteller:</xsl:text>
                            </th>
                            <td>

                              <xsl:value-of select="."/>

                            </td>
                          </tr>
                        </xsl:for-each>
                        <xsl:for-each select="n1:Invoice/cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:Telephone">
                          <tr>
                            <th>
                              <xsl:text>Telefon Rechnungssteller:</xsl:text>
                            </th>
                            <td>

                              <xsl:value-of select="."/>

                            </td>
                          </tr>
                        </xsl:for-each>
                        <xsl:for-each select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:Contact/cbc:ElectronicMail">
                          <tr>
                            <th>
                              <xsl:text>E-Mail Rechnungssteller:</xsl:text>
                            </th>
                            <td>

                              <xsl:value-of select="."/>

                            </td>
                          </tr>
                        </xsl:for-each>
                        <xsl:for-each select="n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:Contact/cbc:Telephone">
                          <tr>
                            <th>
                              <xsl:text>Telefon Rechnungssteller:</xsl:text>
                            </th>
                            <td>

                              <xsl:value-of select="."/>

                            </td>
                          </tr>
                        </xsl:for-each>

                        <xsl:for-each select="//n1:Invoice/cbc:Note">
                          <xsl:call-template name="repNL2">
                            <xsl:with-param name="pText" select="." />
                          </xsl:call-template>
                        </xsl:for-each>

                      </tbody>
                    </table>

                  </div>
                </div>
                <div>
                  <h2>
                    Rechnung <xsl:value-of select="//n1:Invoice/cbc:ID"/>
                  </h2>
                </div>
              </div>
              <div class="satirlar">

                <table id="malHizmetTablosu">
                  <tbody>
                    <tr>
                      <th data-id="SATIRLAR_SIRANO">
                        <xsl:text>
											<![CDATA[Pos]]>
										</xsl:text>
                      </th>
                      <th data-id="SATIRLAR_SATICIURUNKODU">
                        <xsl:text>
											<![CDATA[Artikel-Nr.]]>
										</xsl:text>
                      </th>
                      <th data-id="SATIRLAR_MALHIZMET" class="alignLeft">
                        <xsl:text>
											<![CDATA[Bezeichnung]]>
										</xsl:text>
                      </th>
                      <th data-id="SATIRLAR_MIKTAR">
                        <xsl:text>Menge</xsl:text>
                      </th>
                      <th data-id="SATIRLAR_MIKTAR">
                        <xsl:text>Einheit</xsl:text>
                      </th>
                      <th data-id="SATIRLAR_BIRIMFIYAT">
                        <xsl:text>Einzelpreis</xsl:text>
                      </th>
                      <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:AllowanceCharge/cbc:MultiplierFactorNumeric and //n1:Invoice/cac:InvoiceLine/cac:AllowanceCharge/cbc:MultiplierFactorNumeric !=0">
                        <th data-id="SATIRLAR_ISKONTOORANI">
                          <xsl:text>
												<![CDATA[İskonto Oranı]]>
											</xsl:text>
                        </th>
                      </xsl:if>
                      <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:AllowanceCharge">
                        <th data-id="SATIRLAR_ISKONTOTUTARI">
                          <xsl:text>
												<![CDATA[İskonto Tutarı]]>
											</xsl:text>
                        </th>
                      </xsl:if>

                      <th data-id="SATIRLAR_KDVORANI">
                        <xsl:text>USt. %</xsl:text>
                      </th>

                      <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode ='0015'">
                        <th data-id="SATIRLAR_KDVTUTARI">
                          <xsl:text>KDV Tutarı</xsl:text>
                        </th>
                      </xsl:if>
                      <th data-id="SATIRLAR_MHTUTARI" class="mhColumn">
                        <xsl:text>Gesamtpreis</xsl:text>
                      </th>

                    </tr>
                    <xsl:for-each select="//n1:Invoice/cac:InvoiceLine">
                      <xsl:apply-templates select="."/>
                    </xsl:for-each>
                  </tbody>
                </table>
              </div>

            </xsl:for-each>
            <div id="toplamlarContainer">
              <div class="toplamlar">
                <div class="toplamTablo">
                  <table>
                    <tr>
                      <th>
                        <xsl:text>Gesamtsumme Positionen (Netto):</xsl:text>
                      </th>
                      <td>
                        <xsl:value-of
                      select="format-number(//n1:Invoice/cac:LegalMonetaryTotal/cbc:LineExtensionAmount, '###.##0,00', 'european')"/>
                        <xsl:if
                      test="//n1:Invoice/cac:LegalMonetaryTotal/cbc:LineExtensionAmount/@currencyID">
                          <xsl:text> </xsl:text>
                          <span>
                            <xsl:if
                        test="//n1:Invoice/cbc:DocumentCurrencyCode = 'TRY' or //n1:Invoice/cbc:DocumentCurrencyCode = 'TRL'">
                              <xsl:text>TL</xsl:text>
                            </xsl:if>
                            <xsl:if
                        test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY' and //n1:Invoice/cbc:DocumentCurrencyCode != 'TRL'">
                              <xsl:value-of
                          select="//n1:Invoice/cac:LegalMonetaryTotal/cbc:LineExtensionAmount/@currencyID"
										/>
                            </xsl:if>
                          </span>
                        </xsl:if>
                      </td>
                    </tr>
                    <xsl:if test="//n1:Invoice/cac:LegalMonetaryTotal/cbc:AllowanceTotalAmount !=0">
                      <tr>
                        <th>
                          <xsl:text>Toplam İskonto: </xsl:text>
                        </th>
                        <td>
                          <xsl:value-of select="format-number(//n1:Invoice/cac:LegalMonetaryTotal/cbc:AllowanceTotalAmount, '###.##0,00', 'european')"/>
                          <xsl:if
                      test="//n1:Invoice/cac:LegalMonetaryTotal/cbc:AllowanceTotalAmount/@currencyID">
                            <xsl:text> </xsl:text>
                            <span>
                              <xsl:if
                        test="//n1:Invoice/cbc:DocumentCurrencyCode = 'TRY' or //n1:Invoice/cbc:DocumentCurrencyCode = 'TRL'">
                                <xsl:text>TL</xsl:text>
                              </xsl:if>
                              <xsl:if
                        test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY' and //n1:Invoice/cbc:DocumentCurrencyCode != 'TRL'">
                                <xsl:value-of
                          select="//n1:Invoice/cac:LegalMonetaryTotal/cbc:AllowanceTotalAmount/@currencyID"
										/>
                              </xsl:if>
                            </span>
                          </xsl:if>
                        </td>
                      </tr>
                    </xsl:if>
                    <xsl:if test="//n1:Invoice/cac:LegalMonetaryTotal/cbc:ChargeTotalAmount !=0">
                      <tr>
                        <th>
                          <xsl:text>Toplam Artırım:</xsl:text>
                        </th>
                        <td>
                          <xsl:value-of
                      select="format-number(//n1:Invoice/cac:LegalMonetaryTotal/cbc:ChargeTotalAmount, '###.##0,00', 'european')"/>
                          <xsl:if
                      test="//n1:Invoice/cac:LegalMonetaryTotal/cbc:ChargeTotalAmount/@currencyID">
                            <xsl:text> </xsl:text>
                            <span>
                              <xsl:if
                        test="//n1:Invoice/cbc:DocumentCurrencyCode = 'TRY' or //n1:Invoice/cbc:DocumentCurrencyCode = 'TRL'">
                                <xsl:text>TL</xsl:text>
                              </xsl:if>
                              <xsl:if
                        test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY' and //n1:Invoice/cbc:DocumentCurrencyCode != 'TRL'">
                                <xsl:value-of
                          select="//n1:Invoice/cac:LegalMonetaryTotal/cbc:ChargeTotalAmount/@currencyID"
										/>
                              </xsl:if>
                            </span>
                          </xsl:if>
                        </td>
                      </tr>
                    </xsl:if>
                    <xsl:for-each select="//n1:Invoice/cac:TaxTotal/cac:TaxSubtotal[cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode='0015']">
                      <tr>
                        <th>
                          <xsl:text>KDV Matrahı </xsl:text>
                          <xsl:text>(%</xsl:text>
                          <xsl:value-of select="cbc:Percent"/>
                          <xsl:text>):</xsl:text>
                        </th>

                        <td>
                          <xsl:value-of
                      select="format-number(./cbc:TaxableAmount[../cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode='0015'], '###.##0,00', 'european')"/>
                          <xsl:if
                      test="./cbc:TaxableAmount/@currencyID">
                            <xsl:text> </xsl:text>
                            <span>
                              <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode = 'TRY' or //n1:Invoice/cbc:DocumentCurrencyCode = 'TRL'">
                                <xsl:text>TL</xsl:text>
                              </xsl:if>
                              <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY' and //n1:Invoice/cbc:DocumentCurrencyCode != 'TRL'">
                                <xsl:value-of
                          select="./cbc:TaxableAmount/@currencyID"/>
                              </xsl:if>
                            </span>
                          </xsl:if>
                        </td>
                      </tr>
                    </xsl:for-each>
                    <tr>
                      <th class="sumTitle">
                        <span>
                          <xsl:text>Gesamtsumme (Netto): </xsl:text>
                        </span>
                      </th>

                      <td class="sumValue">
                        <xsl:value-of
                      select="format-number(//n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxExclusiveAmount, '###.##0,00', 'european')"/>
                        <xsl:if
                      test="//n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxExclusiveAmount">
                          <xsl:text> </xsl:text>
                          <span>
                            <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode = 'TRY' or //n1:Invoice/cbc:DocumentCurrencyCode = 'TRL'">
                              <xsl:text>TL</xsl:text>
                            </xsl:if>
                            <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY' and //n1:Invoice/cbc:DocumentCurrencyCode != 'TRL'">
                              <xsl:value-of
                          select="
											//n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxExclusiveAmount/@currencyID"
										/>
                            </xsl:if>
                          </span>
                        </xsl:if>
                      </td>
                    </tr>
                    <xsl:for-each select="n1:Invoice/cac:TaxTotal/cac:TaxSubtotal[not(starts-with(./cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode,'8') and (string-length(./cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode) =3))]">
                      <tr>

                        <th class="sumTitle is-long-{string-length(cac:TaxCategory/cac:TaxScheme/cbc:Name) > 15}">
                          <xsl:text>Steuern </xsl:text>
                          <xsl:value-of select="cac:TaxCategory/cac:TaxScheme/cbc:Name"/>
                          <xsl:text> (%</xsl:text>
                          <xsl:value-of select="cac:TaxCategory/cbc:Percent"/>
                          <xsl:text>) </xsl:text>
                          <xsl:if test="cac:TaxCategory/cbc:TaxExemptionReasonCode > 0">
                            (<xsl:value-of select="cac:TaxCategory/cbc:TaxExemptionReasonCode"/>)
                          </xsl:if>
                          <xsl:text>: </xsl:text>
                        </th>
                        <td class="sumValue">
                          <xsl:for-each select="cac:TaxCategory/cac:TaxScheme">
                            <xsl:text> </xsl:text>
                            <xsl:value-of
                      select="format-number(../../cbc:TaxAmount, '###.##0,00', 'european')"/>
                            <span>
                              <xsl:if test="../../cbc:TaxAmount/@currencyID">
                                <xsl:text> </xsl:text>
                                <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode = 'TRY' or //n1:Invoice/cbc:DocumentCurrencyCode = 'TRL'">
                                  <xsl:text>TL</xsl:text>
                                </xsl:if>
                                <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY' and //n1:Invoice/cbc:DocumentCurrencyCode != 'TRL'">
                                  <xsl:value-of select="../../cbc:TaxAmount/@currencyID"/>
                                </xsl:if>
                              </xsl:if>
                            </span>
                          </xsl:for-each>
                        </td>
                      </tr>
                    </xsl:for-each>
                    <tr>
                      <th>
                        Gesamtsumme (Steuer)
                      </th>
                      <td>
                        <xsl:value-of select="n1:Invoice/cac:TaxTotal/cbc:TaxAmount"/>
                        <xsl:text> </xsl:text>
                        <span>
                          <xsl:value-of select="n1:Invoice/cbc:DocumentCurrencyCode"/>
                        </span>
                      </td>
                    </tr>

                    <xsl:if test="sum(n1:Invoice/cac:TaxTotal/cac:TaxSubtotal[cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode=9015]/cbc:TaxableAmount)>0">
                      <tr>
                        <th>
                          <xsl:text>Tevkifata Tabi İşlem Tutarı:</xsl:text>
                        </th>
                        <td class="sumValue">
                          <xsl:value-of select="format-number(sum(n1:Invoice/cac:InvoiceLine[cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode=9015]/cbc:LineExtensionAmount), '###.##0,00', 'european')"/>
                          <span>
                            <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode = 'TRY' or //n1:Invoice/cbc:DocumentCurrencyCode = 'TRL'">
                              <xsl:text>TL</xsl:text>
                            </xsl:if>
                            <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY' and //n1:Invoice/cbc:DocumentCurrencyCode != 'TRL'">
                              <xsl:value-of select="n1:Invoice/cbc:DocumentCurrencyCode"/>
                            </xsl:if>
                          </span>
                        </td>
                      </tr>
                      <tr>
                        <th>
                          <xsl:text>Tevkifata Tabi İşlem Üzerinden Hes. KDV:</xsl:text>
                        </th>
                        <td class="sumValue">
                          <xsl:value-of select="format-number(sum(n1:Invoice/cac:TaxTotal/cac:TaxSubtotal[cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode=9015]/cbc:TaxableAmount), '###.##0,00', 'european')"/>
                          <span>
                            <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode = 'TRY' or //n1:Invoice/cbc:DocumentCurrencyCode = 'TRL'">
                              <xsl:text>TL</xsl:text>
                            </xsl:if>
                            <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY' and //n1:Invoice/cbc:DocumentCurrencyCode != 'TRL'">
                              <xsl:value-of select="n1:Invoice/cbc:DocumentCurrencyCode"/>
                            </xsl:if>
                          </span>
                        </td>
                      </tr>
                    </xsl:if>


                    <tr>
                      <th>
                        <xsl:text>Gesamtsumme (Brutto):</xsl:text>
                      </th>
                      <td class="sumValue">
                        <xsl:for-each select="n1:Invoice">
                          <xsl:for-each select="cac:LegalMonetaryTotal">
                            <xsl:for-each select="cbc:TaxInclusiveAmount">
                              <xsl:value-of
                          select="format-number(., '###.##0,00', 'european')"/>
                              <xsl:if
                          test="//n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount/@currencyID">
                                <xsl:text> </xsl:text>
                                <span>
                                  <xsl:if
                            test="//n1:Invoice/cbc:DocumentCurrencyCode = 'TRY' or //n1:Invoice/cbc:DocumentCurrencyCode = 'TRL'">
                                    <xsl:text>TL</xsl:text>
                                  </xsl:if>
                                  <xsl:if
                            test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY' and //n1:Invoice/cbc:DocumentCurrencyCode != 'TRL'">
                                    <xsl:value-of
                            select="//n1:Invoice/cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount/@currencyID"
												/>
                                  </xsl:if>
                                </span>
                              </xsl:if>
                            </xsl:for-each>
                          </xsl:for-each>
                        </xsl:for-each>
                      </td>
                    </tr>
                    <tr >

                      <th>

                        <xsl:text>Gesamt:</xsl:text>

                      </th>
                      <td>
                        <xsl:for-each select="n1:Invoice">
                          <xsl:for-each select="cac:LegalMonetaryTotal">

                            <xsl:for-each select="cbc:PayableAmount">

                              <xsl:value-of
                        select="format-number(., '###.##0,00', 'european')"/>

                              <xsl:if
                        test="//n1:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount/@currencyID">
                                <xsl:text> </xsl:text>
                                <span>
                                  <xsl:if
                          test="//n1:Invoice/cbc:DocumentCurrencyCode = 'TRY' or //n1:Invoice/cbc:DocumentCurrencyCode = 'TRL'">
                                    <xsl:text>TL</xsl:text>
                                  </xsl:if>
                                  <xsl:if
                          test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY' and //n1:Invoice/cbc:DocumentCurrencyCode != 'TRL'">
                                    <xsl:value-of
                          select="//n1:Invoice/cac:LegalMonetaryTotal/cbc:PayableAmount/@currencyID" />
                                  </xsl:if>
                                </span>
                              </xsl:if>
                            </xsl:for-each>

                          </xsl:for-each>

                        </xsl:for-each>
                      </td>
                    </tr>
                  </table>
                </div>



              </div>

            </div>


            <div id="notlar">
              <table>
                <tbody>
                  <tr>
                    <td>
                      <span style="font-weight:bold; ">Rechnungstexte:</span>
                      <br/>
                      <xsl:for-each select="//n1:Invoice/cbc:Note">
                        <xsl:choose>
                          <xsl:when test=" starts-with(., '$$')">
                          </xsl:when>
                          <xsl:when test=" starts-with(., '$H')">
                          </xsl:when>

                          <xsl:when test="contains(., '&lt;b&gt;')">
                            <xsl:value-of select="." disable-output-escaping="yes"/>
                          </xsl:when>
                          <xsl:when test="contains(., '&lt;br&gt;')">
                            <xsl:value-of select="." disable-output-escaping="yes"/>
                          </xsl:when>
                          <xsl:when test="contains(., '&lt;table&gt;')">
                            <xsl:value-of select="." disable-output-escaping="yes"/>
                          </xsl:when>
                          <xsl:otherwise>

                            <xsl:if test="substring(.,0,6) != 'Sicil'">
                              <xsl:call-template name="repNL">
                                <xsl:with-param name="pText" select="."/>

                              </xsl:call-template>
                            </xsl:if>
                          </xsl:otherwise>
                        </xsl:choose>

                      </xsl:for-each>



                      <xsl:if test="//n1:Invoice/cac:PaymentMeans">
                        <br/>
                        <span style="font-weight:bold;">
                          <span style="font-weight:bold; ">Banken</span>
                          <br/>
                        </span>



                        <xsl:for-each select="//n1:Invoice/cac:PaymentMeans">


                          <xsl:if test="cac:PayeeFinancialAccount/cbc:ID">
                            <span style="font-weight:bold;"> Kontonummer: </span>
                            <xsl:value-of select="cac:PayeeFinancialAccount/cbc:ID"/>

                          </xsl:if>


                          <br/>

                        </xsl:for-each>

                      </xsl:if>


                      <xsl:if test="//n1:Invoice/cac:InvoicePeriod">
                        <br/>
                        <span style="font-weight:bold;">Rechnungsperiodeninformationen</span>
                        <br/>


                        <xsl:for-each select="//n1:Invoice/cac:InvoicePeriod">
                          <xsl:if test="./cbc:StartDate">
                            <span style="font-weight:bold;">Anfangsdatum:</span>&#160;
                            <xsl:value-of select="substring(./cbc:StartDate,9,2)"
												/>.<xsl:value-of select="substring(./cbc:StartDate,6,2)"
												/>.<xsl:value-of select="substring(./cbc:StartDate,1,4)"/>&#160;&#160;&#160;


                          </xsl:if>
                          <xsl:if test="./cbc:EndDate">
                            <span style="font-weight:bold;">Endtermin:</span>&#160;
                            <xsl:value-of select="substring(./cbc:EndDate,9,2)"
												/>.<xsl:value-of select="substring(./cbc:EndDate,6,2)"
												/>.<xsl:value-of select="substring(./cbc:EndDate,1,4)"/>&#160;&#160;&#160;

                          </xsl:if>



                          <br/>



                        </xsl:for-each>
                        <br/>
                      </xsl:if>

                      <xsl:if test="//n1:Invoice/cac:PaymentTerms">
                        <br/>

                        <span style="font-weight:bold;">Zahlungsbedingungen:</span>

                        <br/>

                        <xsl:for-each select="//n1:Invoice/cac:PaymentTerms">
                          <xsl:if test="./cbc:PenaltySurchargePercent">
                            <span style="font-weight:bold;">Gecikme Ceza Oranı: </span>
                            <xsl:text> %</xsl:text>
                            <xsl:value-of
                      select="format-number(./cbc:PenaltySurchargePercent, '###.##0,00', 'european')"/>&#160;&#160;&#160;
                          </xsl:if>
                          <xsl:if test="./cbc:Amount">
                            <span style="font-weight:bold;">Gecikme Ceza Tutarı:</span>&#160;
                            <xsl:value-of select="format-number(./cbc:Amount, '###.##0,00', 'european')"/>
                          </xsl:if>

                          <xsl:if test="./cbc:Amount/@currencyID">
                            <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode = 'TRY' or //n1:Invoice/cbc:DocumentCurrencyCode = 'TRL'">
                              <xsl:text> TL</xsl:text>&#160;&#160;&#160;
                            </xsl:if>
                            <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY' and //n1:Invoice/cbc:DocumentCurrencyCode != 'TRL'">
                              <xsl:value-of select="./cac:Price/cbc:PriceAmount/@currencyID"/>&#160;&#160;&#160;
                            </xsl:if>
                          </xsl:if>


                          <xsl:if test="./cbc:Note">
                            <span style="font-weight:bold;"/>
                            <xsl:value-of
                                                    select="./cbc:Note"/>
                          </xsl:if>

                          <br/>

                        </xsl:for-each>
                        <br/>
                      </xsl:if>




                    </td>
                  </tr>
                </tbody>
              </table>
            </div>


          </div>
        </div>
      </body>

    </html>

  </xsl:template>

  <xsl:template match="//n1:Invoice/cac:InvoiceLine">
    <tr>
      <td>
        <span>
          <xsl:value-of select="./cbc:ID"/>
        </span>
      </td>

      <td>
        <span>
          <xsl:value-of select="./cac:Item/cac:SellersItemIdentification/cbc:ID"/>
        </span>
      </td>

      <td class="wrap">
        <span>
          <xsl:value-of select="./cac:Item/cbc:Name"/>
          <br/>
          <xsl:value-of select="./cac:Item/cbc:Description"/>
          <xsl:text>&#160;</xsl:text>
          <xsl:value-of select="./cac:Item/cbc:BrandName"/>
          <xsl:text>&#160;</xsl:text>
          <xsl:value-of select="./cac:Item/cbc:ModelName"/>
          <xsl:text>&#160;</xsl:text>
          <xsl:value-of select="./cac:Item/cac:CommodityClassification/cbc:ItemClassificationCode"/>
          <xsl:text>&#160;</xsl:text>
          <xsl:value-of select="./cac:Item/cac:ItemInstance/cbc:SerialID"/>
        </span>
      </td>
      <td>
        <span>
          <xsl:value-of
              select="format-number(./cbc:InvoicedQuantity, '#.###.###,########', 'european')"/>

        </span>
      </td>
      <td >
        <span>
          <xsl:text>&#160;</xsl:text>

          <xsl:if test="./cbc:InvoicedQuantity/@unitCode">
            <xsl:for-each select="./cbc:InvoicedQuantity">
              <xsl:text> </xsl:text>
              <xsl:choose>
                <xsl:when test="@unitCode  = 'XPP'">
                  <span>
                    <xsl:text>Stück</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = '26'">
                  <span>
                    <xsl:text>Tonnen</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'BX'">
                  <span>
                    <xsl:text>Kutu</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'LTR'">
                  <span>
                    <xsl:text>Liter</xsl:text>
                  </span>
                </xsl:when>

                <xsl:when test="@unitCode  = 'NIU'">
                  <span>
                    <xsl:text>Stück</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'KGM'">
                  <span>
                    <xsl:text>KG</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'KJO'">
                  <span>
                    <xsl:text>kJ</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'GRM'">
                  <span>
                    <xsl:text>G</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'MGM'">
                  <span>
                    <xsl:text>MG</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'NT'">
                  <span>
                    <xsl:text>Net Ton</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'GT'">
                  <span>
                    <xsl:text>GT</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'MTR'">
                  <span>
                    <xsl:text>M</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'MMT'">
                  <span>
                    <xsl:text>MM</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'KTM'">
                  <span>
                    <xsl:text>KM</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'MLT'">
                  <span>
                    <xsl:text>ML</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'MMQ'">
                  <span>
                    <xsl:text>MM3</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'CLT'">
                  <span>
                    <xsl:text>CL</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'CMK'">
                  <span>
                    <xsl:text>CM2</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'CMQ'">
                  <span>
                    <xsl:text>CM3</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'CMT'">
                  <span>
                    <xsl:text>CM</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'MTK'">
                  <span>
                    <xsl:text>M2</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'MTQ'">
                  <span>
                    <xsl:text>M3</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'DAY'">
                  <span>
                    <xsl:text> Tag</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'MON'">
                  <span>
                    <xsl:text> Monat</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'PA'">
                  <span>
                    <xsl:text> Paket</xsl:text>
                  </span>
                </xsl:when>
                <xsl:when test="@unitCode  = 'KWH'">
                  <span>
                    <xsl:text> KWH</xsl:text>
                  </span>
                </xsl:when>
              </xsl:choose>
            </xsl:for-each>
          </xsl:if>
        </span>
      </td>
      <td>
        <span>
          <xsl:value-of
              select="format-number(./cac:Price/cbc:PriceAmount, '###.##0,########', 'european')"/>
          <xsl:if test="./cac:Price/cbc:PriceAmount/@currencyID">
            <xsl:text> </xsl:text>
            <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode = 'TRY' or //n1:Invoice/cbc:DocumentCurrencyCode = 'TRL'">
              <xsl:text>TL</xsl:text>
            </xsl:if>
            <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY' and //n1:Invoice/cbc:DocumentCurrencyCode != 'TRL'">
              <xsl:value-of select="./cac:Price/cbc:PriceAmount/@currencyID"/>
            </xsl:if>
          </xsl:if>
        </span>
      </td>
      <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:AllowanceCharge/cbc:MultiplierFactorNumeric and //n1:Invoice/cac:InvoiceLine/cac:AllowanceCharge/cbc:MultiplierFactorNumeric !=0">
        <td>
          <span>
            <xsl:text>&#160;</xsl:text>
            <xsl:if test="./cac:AllowanceCharge/cbc:MultiplierFactorNumeric">
              <xsl:text> %</xsl:text>
              <xsl:value-of
                  select="format-number(./cac:AllowanceCharge/cbc:MultiplierFactorNumeric * 100, '###.##0,00', 'european')"
							/>
            </xsl:if>
          </span>
        </td>
      </xsl:if>
      <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:AllowanceCharge">
        <td>
          <span>
            <xsl:if test="./cac:AllowanceCharge">
              <xsl:if test="./cac:AllowanceCharge/cbc:ChargeIndicator = 'true' and not(./cac:AllowanceCharge/cbc:Amount =0) ">(A)</xsl:if>
              <xsl:if test="./cac:AllowanceCharge/cbc:ChargeIndicator = 'false' ">
              </xsl:if>
              <xsl:value-of select="format-number(./cac:AllowanceCharge/cbc:Amount, '###.##0,00', 'european')"/>
            </xsl:if>
            <xsl:if test="./cac:AllowanceCharge/cbc:Amount/@currencyID">
              <xsl:text> </xsl:text>
              <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode = 'TRY' or //n1:Invoice/cbc:DocumentCurrencyCode = 'TRL'">
                <xsl:text>TL</xsl:text>
              </xsl:if>
              <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY' and //n1:Invoice/cbc:DocumentCurrencyCode != 'TRL'">
                <xsl:value-of select="./cac:AllowanceCharge/cbc:Amount/@currencyID"/>
              </xsl:if>
            </xsl:if>
          </span>
        </td>
      </xsl:if>

      <td>
        <span>
          <xsl:for-each
              select="./cac:Item/cac:ClassifiedTaxCategory">

            <xsl:value-of
                    select="format-number(cbc:Percent, '###.##0,00', 'european')"
								/>


          </xsl:for-each>
        </span>
      </td>

      <xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode ='0015'">
        <td>
          <span>
            <xsl:text>&#160;</xsl:text>
            <xsl:for-each
              select="./cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme">
              <xsl:if test="cbc:TaxTypeCode='0015' ">
                <xsl:text> </xsl:text>
                <xsl:value-of
                  select="format-number(../../cbc:TaxAmount, '###.##0,00', 'european')"/>
                <xsl:if test="../../cbc:TaxAmount/@currencyID">
                  <xsl:text> </xsl:text>
                  <xsl:if test="../../cbc:TaxAmount/@currencyID = 'TRY' or ../../cbc:TaxAmount/@currencyID = 'TRL'">
                    <xsl:text>TL</xsl:text>
                  </xsl:if>
                  <xsl:if test="../../cbc:TaxAmount/@currencyID != 'TRY' and ../../cbc:TaxAmount/@currencyID != 'TRL'">
                    <xsl:value-of select="../../cbc:TaxAmount/@currencyID"/>
                  </xsl:if>
                </xsl:if>
              </xsl:if>
            </xsl:for-each>
          </span>
        </td>
      </xsl:if>
      <td>
        <span>
          <xsl:text>&#160;</xsl:text>
          <xsl:value-of
              select="format-number(./cbc:LineExtensionAmount, '###.##0,00', 'european')"/>
          <xsl:if test="./cbc:LineExtensionAmount/@currencyID">
            <xsl:text> </xsl:text>
            <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode = 'TRY' or //n1:Invoice/cbc:DocumentCurrencyCode = 'TRL'">
              <xsl:text>TL</xsl:text>
            </xsl:if>
            <xsl:if test="//n1:Invoice/cbc:DocumentCurrencyCode != 'TRY' and //n1:Invoice/cbc:DocumentCurrencyCode != 'TRL'">
              <xsl:value-of select="./cbc:LineExtensionAmount/@currencyID"/>
            </xsl:if>
          </xsl:if>
        </span>
      </td>

    </tr>
  </xsl:template>

</xsl:stylesheet>