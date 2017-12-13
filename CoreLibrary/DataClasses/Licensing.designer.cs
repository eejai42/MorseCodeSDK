using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Licensing
    {
        private void InitPoco()
        {
            
            this.LicensingId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LicensingId")]
        public Guid LicensingId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateLicensingWhere(IEnumerable<Licensing> licensings)
        {
            if (!licensings.Any()) return "1=1";
            else 
            {
                var idList = licensings.Select(selectLicensing => String.Format("'{0}'", selectLicensing.LicensingId));
                var csIdList = String.Join(",", idList);
                return String.Format("LicensingId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Licensing> licensings, string expandString)
        {
            
        }
        
    }
}