using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Country
    {
        private void InitPoco()
        {
            
            this.CountryId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CountryId")]
        public Guid CountryId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateCountryWhere(IEnumerable<Country> countries)
        {
            if (!countries.Any()) return "1=1";
            else 
            {
                var idList = countries.Select(selectCountry => String.Format("'{0}'", selectCountry.CountryId));
                var csIdList = String.Join(",", idList);
                return String.Format("CountryId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Country> countries, string expandString)
        {
            
        }
        
    }
}