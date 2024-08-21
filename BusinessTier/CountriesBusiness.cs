using DataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class clsCountries
    {
        public static int GetCountryID(string country)
        {
            return clsCountriesData.GetCountryID(country);

        }
        public static string GetCountryName(int CountryID) 
        {
            return clsCountriesData.GetCountryName(CountryID);
        }
        public static DataTable GetCountries()
        {
            return clsCountriesData.GetCountries();
        }
    }
}
