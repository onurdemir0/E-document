﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_document.Entities
{
	public class Country : SelectOption
	{
        public static List<Country> GetCountriesToDe()
        {
            List<Country> list = new List<Country>();
            list.Add(new Country() { Code = "AF", Name = "Afghanistan" });
            list.Add(new Country() { Code = "EG", Name = "Ägypten" });
            list.Add(new Country() { Code = "AL", Name = "Albanien" });
            list.Add(new Country() { Code = "DZ", Name = "Algerien" });
            list.Add(new Country() { Code = "AD", Name = "Andorra" });
            list.Add(new Country() { Code = "AO", Name = "Angola" });
            list.Add(new Country() { Code = "GQ", Name = "Äquatorialguinea" });
            list.Add(new Country() { Code = "AR", Name = "Argentinien" });
            list.Add(new Country() { Code = "AM", Name = "Armenien" });
            list.Add(new Country() { Code = "AZ", Name = "Aserbaidschan" });
            list.Add(new Country() { Code = "ET", Name = "Äthiopien" });
            list.Add(new Country() { Code = "AU", Name = "Australien" });
            list.Add(new Country() { Code = "BS", Name = "Bahamas" });
            list.Add(new Country() { Code = "BH", Name = "Bahrain" });
            list.Add(new Country() { Code = "BD", Name = "Bangladesch" });
            list.Add(new Country() { Code = "BB", Name = "Barbados" });
            list.Add(new Country() { Code = "BY", Name = "Belarus (Weißrussland)" });
            list.Add(new Country() { Code = "BE", Name = "Belgien" });
            list.Add(new Country() { Code = "BZ", Name = "Belize" });
            list.Add(new Country() { Code = "BO", Name = "Bolivien" });
            list.Add(new Country() { Code = "BA", Name = "Bosnien und Herzegowina" });
            list.Add(new Country() { Code = "BW", Name = "Botswana" });
            list.Add(new Country() { Code = "BR", Name = "Brasilien" });
            list.Add(new Country() { Code = "BG", Name = "Bulgarien" });
            list.Add(new Country() { Code = "BF", Name = "Burkina Faso" });
            list.Add(new Country() { Code = "CL", Name = "Chile" });
            list.Add(new Country() { Code = "CN", Name = "China" });
            list.Add(new Country() { Code = "CR", Name = "Costa Rica" });
            list.Add(new Country() { Code = "CI", Name = "Côte d’Ivoire (Elfenbeinküste)" });
            list.Add(new Country() { Code = "DK", Name = "Dänemark" });
            list.Add(new Country() { Code = "DE", Name = "Deutschland" });
            list.Add(new Country() { Code = "DO", Name = "Dominikanische Republik" });
            list.Add(new Country() { Code = "EC", Name = "Ecuador" });
            list.Add(new Country() { Code = "SV", Name = "El Salvador" });
            list.Add(new Country() { Code = "ER", Name = "Eritrea" });
            list.Add(new Country() { Code = "EE", Name = "Estland" });
            list.Add(new Country() { Code = "FI", Name = "Finnland" });
            list.Add(new Country() { Code = "FR", Name = "Frankreich" });
            list.Add(new Country() { Code = "GA", Name = "Gabun" });
            list.Add(new Country() { Code = "GM", Name = "Gambia" });
            list.Add(new Country() { Code = "GE", Name = "Georgien" });
            list.Add(new Country() { Code = "GH", Name = "Ghana" });
            list.Add(new Country() { Code = "GI", Name = "Gibraltar" });
            list.Add(new Country() { Code = "GR", Name = "Griechenland" });
            list.Add(new Country() { Code = "GB", Name = "Großbritannien und Nordirland" });
            list.Add(new Country() { Code = "GT", Name = "Guatemala" });
            list.Add(new Country() { Code = "GN", Name = "Guinea" });
            list.Add(new Country() { Code = "GW", Name = "Guinea-Bissau" });
            list.Add(new Country() { Code = "GY", Name = "Guyana" });
            list.Add(new Country() { Code = "HT", Name = "Haiti" });
            list.Add(new Country() { Code = "HN", Name = "Honduras" });
            list.Add(new Country() { Code = "IN", Name = "Indien" });
            list.Add(new Country() { Code = "ID", Name = "Indonesien" });
            list.Add(new Country() { Code = "IQ", Name = "Irak" });
            list.Add(new Country() { Code = "IR", Name = "Iran" });
            list.Add(new Country() { Code = "IE", Name = "Irland" });
            list.Add(new Country() { Code = "IS", Name = "Island" });
            list.Add(new Country() { Code = "IL", Name = "Israel" });
            list.Add(new Country() { Code = "IT", Name = "Italien" });
            list.Add(new Country() { Code = "JM", Name = "Jamaika" });
            list.Add(new Country() { Code = "JP", Name = "Japan" });
            list.Add(new Country() { Code = "YE", Name = "Jemen" });
            list.Add(new Country() { Code = "JO", Name = "Jordanien" });
            list.Add(new Country() { Code = "KH", Name = "Kambodscha" });
            list.Add(new Country() { Code = "CM", Name = "Kamerun" });
            list.Add(new Country() { Code = "CA", Name = "Kanada" });
            list.Add(new Country() { Code = "KZ", Name = "Kasachstan" });
            list.Add(new Country() { Code = "QA", Name = "Katar" });
            list.Add(new Country() { Code = "KE", Name = "Kenia" });
            list.Add(new Country() { Code = "KG", Name = "Kirgisistan" });
            list.Add(new Country() { Code = "CO", Name = "Kolumbien" });
            list.Add(new Country() { Code = "CD", Name = "Kongo" });
            list.Add(new Country() { Code = "XK", Name = "Kosovo" });
            list.Add(new Country() { Code = "HR", Name = "Kroatien" });
            list.Add(new Country() { Code = "CU", Name = "Kuba" });
            list.Add(new Country() { Code = "KW", Name = "Kuwait" });
            list.Add(new Country() { Code = "LA", Name = "Laos" });
            list.Add(new Country() { Code = "LS", Name = "Lesotho" });
            list.Add(new Country() { Code = "LV", Name = "Lettland" });
            list.Add(new Country() { Code = "LB", Name = "Libanon" });
            list.Add(new Country() { Code = "LR", Name = "Liberia" });
            list.Add(new Country() { Code = "LY", Name = "Libyen" });
            list.Add(new Country() { Code = "LI", Name = "Liechtenstein" });
            list.Add(new Country() { Code = "LT", Name = "Litauen" });
            list.Add(new Country() { Code = "LU", Name = "Luxemburg" });
            list.Add(new Country() { Code = "MG", Name = "Madagaskar" });
            list.Add(new Country() { Code = "MW", Name = "Malawi" });
            list.Add(new Country() { Code = "MY", Name = "Malaysia" });
            list.Add(new Country() { Code = "MV", Name = "Malediven" });
            list.Add(new Country() { Code = "ML", Name = "Mali" });
            list.Add(new Country() { Code = "MT", Name = "Malta" });
            list.Add(new Country() { Code = "MA", Name = "Marokko" });
            list.Add(new Country() { Code = "MR", Name = "Mauretanien" });
            list.Add(new Country() { Code = "MU", Name = "Mauritius" });
            list.Add(new Country() { Code = "MK", Name = "Mazedonien" });
            list.Add(new Country() { Code = "MX", Name = "Mexiko" });
            list.Add(new Country() { Code = "MD", Name = "Moldawien" });
            list.Add(new Country() { Code = "MC", Name = "Monaco" });
            list.Add(new Country() { Code = "MN", Name = "Mongolei" });
            list.Add(new Country() { Code = "ME", Name = "Montenegro" });
            list.Add(new Country() { Code = "MZ", Name = "Mosambik" });
            list.Add(new Country() { Code = "MM", Name = "Myanmar (Burma)" });
            list.Add(new Country() { Code = "NA", Name = "Namibia" });
            list.Add(new Country() { Code = "NP", Name = "Nepal" });
            list.Add(new Country() { Code = "NZ", Name = "Neuseeland" });
            list.Add(new Country() { Code = "NI", Name = "Nicaragua" });
            list.Add(new Country() { Code = "NL", Name = "Niederlande" });
            list.Add(new Country() { Code = "NE", Name = "Niger" });
            list.Add(new Country() { Code = "NG", Name = "Nigeria" });
            list.Add(new Country() { Code = "KP", Name = "Nordkorea" });
            list.Add(new Country() { Code = "NO", Name = "Norwegen" });
            list.Add(new Country() { Code = "OM", Name = "Oman" });
            list.Add(new Country() { Code = "AT", Name = "Österreich" });
            list.Add(new Country() { Code = "TL", Name = "Osttimor (Timor-Leste)" });
            list.Add(new Country() { Code = "PK", Name = "Pakistan" });
            list.Add(new Country() { Code = "PS", Name = "Palästina" });
            list.Add(new Country() { Code = "PA", Name = "Panama" });
            list.Add(new Country() { Code = "PG", Name = "Papua-Neuguinea" });
            list.Add(new Country() { Code = "PY", Name = "Paraguay" });
            list.Add(new Country() { Code = "PE", Name = "Peru" });
            list.Add(new Country() { Code = "PH", Name = "Philippinen" });
            list.Add(new Country() { Code = "PL", Name = "Polen" });
            list.Add(new Country() { Code = "PT", Name = "Portugal" });
            list.Add(new Country() { Code = "PR", Name = "Puerto Rico" });
            list.Add(new Country() { Code = "RW", Name = "Ruanda" });
            list.Add(new Country() { Code = "RO", Name = "Rumänien" });
            list.Add(new Country() { Code = "RU", Name = "Russland" });
            list.Add(new Country() { Code = "ZM", Name = "Sambia" });
            list.Add(new Country() { Code = "SM", Name = "San Marino" });
            list.Add(new Country() { Code = "SA", Name = "Saudi-Arabien" });
            list.Add(new Country() { Code = "SE", Name = "Schweden" });
            list.Add(new Country() { Code = "CH", Name = "Schweiz" });
            list.Add(new Country() { Code = "SN", Name = "Senegal" });
            list.Add(new Country() { Code = "RS", Name = "Serbien" });
            list.Add(new Country() { Code = "SC", Name = "Seychellen" });
            list.Add(new Country() { Code = "SL", Name = "Sierra Leone" });
            list.Add(new Country() { Code = "ZW", Name = "Simbabwe" });
            list.Add(new Country() { Code = "SG", Name = "Singapur" });
            list.Add(new Country() { Code = "SK", Name = "Slowakei" });
            list.Add(new Country() { Code = "SI", Name = "Slowenien" });
            list.Add(new Country() { Code = "SO", Name = "Somalia" });
            list.Add(new Country() { Code = "ES", Name = "Spanien" });
            list.Add(new Country() { Code = "LK", Name = "Sri Lanka" });
            list.Add(new Country() { Code = "ZA", Name = "Südafrika" });
            list.Add(new Country() { Code = "SD", Name = "Sudan" });
            list.Add(new Country() { Code = "KR", Name = "Südkorea" });
            list.Add(new Country() { Code = "SS", Name = "Südsudan" });
            list.Add(new Country() { Code = "SR", Name = "Suriname" });
            list.Add(new Country() { Code = "SZ", Name = "Swasiland" });
            list.Add(new Country() { Code = "SY", Name = "Syrien" });
            list.Add(new Country() { Code = "TJ", Name = "Tadschikistan" });
            list.Add(new Country() { Code = "TZ", Name = "Tansania" });
            list.Add(new Country() { Code = "TH", Name = "Thailand" });
            list.Add(new Country() { Code = "TG", Name = "Togo" });
            list.Add(new Country() { Code = "TD", Name = "Tschad" });
            list.Add(new Country() { Code = "CZ", Name = "Tschechien" });
            list.Add(new Country() { Code = "TN", Name = "Tunesien" });
            list.Add(new Country() { Code = "TR", Name = "Türkei" });
            list.Add(new Country() { Code = "TM", Name = "Turkmenistan" });
            list.Add(new Country() { Code = "UG", Name = "Uganda" });
            list.Add(new Country() { Code = "UA", Name = "Ukraine" });
            list.Add(new Country() { Code = "HU", Name = "Ungarn" });
            list.Add(new Country() { Code = "UY", Name = "Uruguay" });
            list.Add(new Country() { Code = "UZ", Name = "Usbekistan" });
            list.Add(new Country() { Code = "VA", Name = "Vatikanstadt" });
            list.Add(new Country() { Code = "VE", Name = "Venezuela" });
            list.Add(new Country() { Code = "AE", Name = "Vereinigte Arabische Emirate" });
            list.Add(new Country() { Code = "US", Name = "Vereinigte Staaten von Amerika" });
            list.Add(new Country() { Code = "VN", Name = "Vietnam" });
            list.Add(new Country() { Code = "EH", Name = "Westsahara" });
            list.Add(new Country() { Code = "CF", Name = "Zentralafrikanische Republik" });
            list.Add(new Country() { Code = "CY", Name = "Zypern" });
            return list;
        }
        public static List<Country> GetCountriesToEn()
        {
            List<Country> list = new List<Country>();
            list.Add(new Country() { Code = "AF", Name = "Afghanistan" });
            list.Add(new Country() { Code = "AL", Name = "Albania" });
            list.Add(new Country() { Code = "DZ", Name = "Algeria" });
            list.Add(new Country() { Code = "AD", Name = "Andorra" });
            list.Add(new Country() { Code = "AO", Name = "Angola" });
            list.Add(new Country() { Code = "AR", Name = "Argentina" });
            list.Add(new Country() { Code = "AM", Name = "Armenia" });
            list.Add(new Country() { Code = "AT", Name = "Austria" });
            list.Add(new Country() { Code = "AZ", Name = "Azerbaijan" });
            list.Add(new Country() { Code = "AU", Name = "Australia" });
            list.Add(new Country() { Code = "BS", Name = "Bahamas" });
            list.Add(new Country() { Code = "BH", Name = "Bahrain" });
            list.Add(new Country() { Code = "BD", Name = "Bangladesh" });
            list.Add(new Country() { Code = "BB", Name = "Barbados" });
            list.Add(new Country() { Code = "BY", Name = "Belarus" });
            list.Add(new Country() { Code = "BE", Name = "Belgium" });
            list.Add(new Country() { Code = "BZ", Name = "Belize" });
            list.Add(new Country() { Code = "BO", Name = "Bolivia" });
            list.Add(new Country() { Code = "BA", Name = "Bosnia and Herzegovina" });
            list.Add(new Country() { Code = "BW", Name = "Botswana" });
            list.Add(new Country() { Code = "BR", Name = "Brazil" });
            list.Add(new Country() { Code = "BG", Name = "Bulgaria" });
            list.Add(new Country() { Code = "BF", Name = "Burkina Faso" });
            list.Add(new Country() { Code = "KH", Name = "Cambodia" });
            list.Add(new Country() { Code = "CM", Name = "Cameroon" });
            list.Add(new Country() { Code = "CA", Name = "Canada" });
            list.Add(new Country() { Code = "CF", Name = "Central African Republic" });
            list.Add(new Country() { Code = "TD", Name = "Chad" });
            list.Add(new Country() { Code = "CL", Name = "Chile" });
            list.Add(new Country() { Code = "CN", Name = "China" });
            list.Add(new Country() { Code = "CO", Name = "Columbia" });
            list.Add(new Country() { Code = "CD", Name = "Congo" });
            list.Add(new Country() { Code = "CR", Name = "Costa Rica" });
            list.Add(new Country() { Code = "HR", Name = "Croatia" });
            list.Add(new Country() { Code = "CU", Name = "Cuba" });
            list.Add(new Country() { Code = "CY", Name = "Cyprus" });
            list.Add(new Country() { Code = "CZ", Name = "Czech Republic" });
            list.Add(new Country() { Code = "DK", Name = "Denmark" });
            list.Add(new Country() { Code = "DO", Name = "Dominican Republic" });
            list.Add(new Country() { Code = "TL", Name = "East Timor (Timor-Leste)" });
            list.Add(new Country() { Code = "EC", Name = "Ecuador" });
            list.Add(new Country() { Code = "EG", Name = "Egypt" });
            list.Add(new Country() { Code = "SV", Name = "El Salvador" });
            list.Add(new Country() { Code = "GQ", Name = "Equatorial Guinea" });
            list.Add(new Country() { Code = "ER", Name = "Eritrea" });
            list.Add(new Country() { Code = "EE", Name = "Estonia" });
            list.Add(new Country() { Code = "ET", Name = "Ethiopia" });
            list.Add(new Country() { Code = "FI", Name = "Finland" });
            list.Add(new Country() { Code = "FR", Name = "France" });
            list.Add(new Country() { Code = "GA", Name = "Gabun" });
            list.Add(new Country() { Code = "GM", Name = "Gambia" });
            list.Add(new Country() { Code = "GE", Name = "Georgia" });
            list.Add(new Country() { Code = "DE", Name = "Germany" });
            list.Add(new Country() { Code = "GH", Name = "Ghana" });
            list.Add(new Country() { Code = "GI", Name = "Gibraltar" });
            list.Add(new Country() { Code = "GR", Name = "Greece" });
            list.Add(new Country() { Code = "GT", Name = "Guatemala" });
            list.Add(new Country() { Code = "GN", Name = "Guinea" });
            list.Add(new Country() { Code = "GW", Name = "Guinea-Bissau" });
            list.Add(new Country() { Code = "GY", Name = "Guyana" });
            list.Add(new Country() { Code = "HT", Name = "Haiti" });
            list.Add(new Country() { Code = "HN", Name = "Honduras" });
            list.Add(new Country() { Code = "HU", Name = "Hungary" });
            list.Add(new Country() { Code = "IN", Name = "India" });
            list.Add(new Country() { Code = "ID", Name = "Indonesia" });
            list.Add(new Country() { Code = "IQ", Name = "Iraq" });
            list.Add(new Country() { Code = "IR", Name = "Iran" });
            list.Add(new Country() { Code = "IE", Name = "Ireland" });
            list.Add(new Country() { Code = "IS", Name = "Island" });
            list.Add(new Country() { Code = "IL", Name = "Israel" });
            list.Add(new Country() { Code = "IT", Name = "Italy" });
            list.Add(new Country() { Code = "CI", Name = "Ivory Coast" });
            list.Add(new Country() { Code = "JM", Name = "Jamaica" });
            list.Add(new Country() { Code = "JP", Name = "Japan" });
            list.Add(new Country() { Code = "JO", Name = "Jordan" });
            list.Add(new Country() { Code = "KZ", Name = "Kazachstan" });
            list.Add(new Country() { Code = "KE", Name = "Kenya" });
            list.Add(new Country() { Code = "KG", Name = "Kyrgyzstan" });
            list.Add(new Country() { Code = "XK", Name = "Kosovo" });
            list.Add(new Country() { Code = "KW", Name = "Kuwait" });
            list.Add(new Country() { Code = "LA", Name = "Laos" });
            list.Add(new Country() { Code = "LS", Name = "Lesotho" });
            list.Add(new Country() { Code = "LV", Name = "Latvia" });
            list.Add(new Country() { Code = "LB", Name = "Lebanon" });
            list.Add(new Country() { Code = "LR", Name = "Liberia" });
            list.Add(new Country() { Code = "LY", Name = "Libya" });
            list.Add(new Country() { Code = "LI", Name = "Liechtenstein" });
            list.Add(new Country() { Code = "LT", Name = "Lithuania" });
            list.Add(new Country() { Code = "LU", Name = "Luxembourg" });
            list.Add(new Country() { Code = "MG", Name = "Madagascar" });
            list.Add(new Country() { Code = "MW", Name = "Malawi" });
            list.Add(new Country() { Code = "MY", Name = "Malaysia" });
            list.Add(new Country() { Code = "MV", Name = "Maldives" });
            list.Add(new Country() { Code = "ML", Name = "Mali" });
            list.Add(new Country() { Code = "MT", Name = "Malta" });
            list.Add(new Country() { Code = "MA", Name = "Morocco" });
            list.Add(new Country() { Code = "MR", Name = "Mauritania" });
            list.Add(new Country() { Code = "MU", Name = "Mauritius" });
            list.Add(new Country() { Code = "MK", Name = "Macedonia" });
            list.Add(new Country() { Code = "MX", Name = "Mexico" });
            list.Add(new Country() { Code = "MD", Name = "Moldova" });
            list.Add(new Country() { Code = "MC", Name = "Monaco" });
            list.Add(new Country() { Code = "MN", Name = "Mongolia" });
            list.Add(new Country() { Code = "ME", Name = "Montenegro" });
            list.Add(new Country() { Code = "MZ", Name = "Mozambique" });
            list.Add(new Country() { Code = "MM", Name = "Myanmar (Burma)" });
            list.Add(new Country() { Code = "NA", Name = "Namibia" });
            list.Add(new Country() { Code = "NP", Name = "Nepal" });
            list.Add(new Country() { Code = "NI", Name = "Nicaraguan" });
            list.Add(new Country() { Code = "NL", Name = "Netherlands" });
            list.Add(new Country() { Code = "NE", Name = "Niger" });
            list.Add(new Country() { Code = "NG", Name = "Nigeria" });
            list.Add(new Country() { Code = "KP", Name = "North Korea" });
            list.Add(new Country() { Code = "NO", Name = "Norway" });
            list.Add(new Country() { Code = "OM", Name = "Oman" });
            list.Add(new Country() { Code = "PK", Name = "Pakistan" });
            list.Add(new Country() { Code = "PS", Name = "Palestinian territory" });
            list.Add(new Country() { Code = "PA", Name = "Panama" });
            list.Add(new Country() { Code = "PG", Name = "Papua New Guinea" });
            list.Add(new Country() { Code = "PY", Name = "Paraguay" });
            list.Add(new Country() { Code = "PE", Name = "Peru" });
            list.Add(new Country() { Code = "PH", Name = "Philippines" });
            list.Add(new Country() { Code = "PL", Name = "Poland" });
            list.Add(new Country() { Code = "PT", Name = "Portugal" });
            list.Add(new Country() { Code = "PR", Name = "Puerto Rico" });
            list.Add(new Country() { Code = "QA", Name = "Qatar" });
            list.Add(new Country() { Code = "RW", Name = "Rwanda" });
            list.Add(new Country() { Code = "RO", Name = "Romania" });
            list.Add(new Country() { Code = "RU", Name = "Russia" });
            list.Add(new Country() { Code = "SM", Name = "San Marino" });
            list.Add(new Country() { Code = "SA", Name = "Saudi-Arabia" });
            list.Add(new Country() { Code = "SN", Name = "Senegal" });
            list.Add(new Country() { Code = "RS", Name = "Serbia" });
            list.Add(new Country() { Code = "SC", Name = "Seychelles" });
            list.Add(new Country() { Code = "SL", Name = "Sierra Leone" });
            list.Add(new Country() { Code = "SG", Name = "Singapore" });
            list.Add(new Country() { Code = "SK", Name = "Slovakia" });
            list.Add(new Country() { Code = "SI", Name = "Slovenia" });
			list.Add(new Country() { Code = "SO", Name = "Somalia" });
			list.Add(new Country() { Code = "ES", Name = "Spain" });
            list.Add(new Country() { Code = "LK", Name = "Sri Lanka" });
            list.Add(new Country() { Code = "ZA", Name = "South Africa" });
            list.Add(new Country() { Code = "SD", Name = "Sudan" });
            list.Add(new Country() { Code = "KR", Name = "South Korea" });
            list.Add(new Country() { Code = "SS", Name = "Southern Sudan" });
            list.Add(new Country() { Code = "SR", Name = "Suriname" });
            list.Add(new Country() { Code = "SZ", Name = "Swaziland" });
            list.Add(new Country() { Code = "SE", Name = "Sweden" });
            list.Add(new Country() { Code = "CH", Name = "Switzerland" });
            list.Add(new Country() { Code = "SY", Name = "Syria" });
            list.Add(new Country() { Code = "TJ", Name = "Tajikistan" });
            list.Add(new Country() { Code = "TZ", Name = "Tanzania" });
            list.Add(new Country() { Code = "TH", Name = "Thailand" });
            list.Add(new Country() { Code = "TG", Name = "Togo" });   
            list.Add(new Country() { Code = "TN", Name = "Tunisia" });
            list.Add(new Country() { Code = "TR", Name = "Turkey" });
            list.Add(new Country() { Code = "TM", Name = "Turkmenistan" });
            list.Add(new Country() { Code = "UG", Name = "Uganda" });
            list.Add(new Country() { Code = "UA", Name = "Ukraine" });
            list.Add(new Country() { Code = "AE", Name = "United Arab Emirates" });
            list.Add(new Country() { Code = "GB", Name = "United Kingdom" });
            list.Add(new Country() { Code = "US", Name = "United States of America" });
            list.Add(new Country() { Code = "UY", Name = "Uruguay" });
            list.Add(new Country() { Code = "UZ", Name = "Uzbekistan" });
            list.Add(new Country() { Code = "VA", Name = "Vatican" });
            list.Add(new Country() { Code = "VE", Name = "Venezuela" });
            list.Add(new Country() { Code = "VN", Name = "Vietnam" });
            list.Add(new Country() { Code = "EH", Name = "Western Sahara" });
            list.Add(new Country() { Code = "YE", Name = "Yemen" });
            list.Add(new Country() { Code = "ZM", Name = "Zambia" });
            list.Add(new Country() { Code = "NZ", Name = "Zealand" });
            list.Add(new Country() { Code = "ZW", Name = "Zimbabwe" });

            return list;
        }

    }
}