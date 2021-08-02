using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_document.Entities
{
	public class MeasurementUnit : SelectOption
	{
        public static List<MeasurementUnit> GetUnits()
        {
            List<MeasurementUnit> list = new List<MeasurementUnit>();
            list.Add(new MeasurementUnit() { Code = "E48W", Name = "Arbeitswert" });
            list.Add(new MeasurementUnit() { Code = "BLL", Name = "Fass" });
            list.Add(new MeasurementUnit() { Code = "FOT", Name = "Fuß" });
            list.Add(new MeasurementUnit() { Code = "GRM", Name = "Gramm" });
            list.Add(new MeasurementUnit() { Code = "KGM", Name = "Kilogramm" });
            list.Add(new MeasurementUnit() { Code = "KMT", Name = "Kilometer" });
            list.Add(new MeasurementUnit() { Code = "KWH", Name = "Kilowattstunde" });
            list.Add(new MeasurementUnit() { Code = "MTQ", Name = "Kubikmeter" });
            list.Add(new MeasurementUnit() { Code = "E48S", Name = "Leistungseinheit" });
            list.Add(new MeasurementUnit() { Code = "LTR", Name = "Liter" });
            list.Add(new MeasurementUnit() { Code = "SMI", Name = "Meile" });
            list.Add(new MeasurementUnit() { Code = "MTR", Name = "Meter" });
            list.Add(new MeasurementUnit() { Code = "DAY", Name = "Personentage" });
            list.Add(new MeasurementUnit() { Code = "MIK", Name = "Quadratmeile" });
            list.Add(new MeasurementUnit() { Code = "MTK", Name = "Quadratmeter" });
            list.Add(new MeasurementUnit() { Code = "YRD", Name = "Schritt" });
            list.Add(new MeasurementUnit() { Code = "C62", Name = "Stück" });
            list.Add(new MeasurementUnit() { Code = "HUR", Name = "Stunde" });
            list.Add(new MeasurementUnit() { Code = "TNE", Name = "Tonne" });
            list.Add(new MeasurementUnit() { Code = "CMT", Name = "Zentimeter" });
            list.Add(new MeasurementUnit() { Code = "INH", Name = "Zoll" });

            return list;
        }
    }
}
