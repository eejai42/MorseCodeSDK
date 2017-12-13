using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Decodingsoftware
    {
        private void InitPoco()
        {
            
            this.DecodingsoftwareId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DecodingsoftwareId")]
        public Guid DecodingsoftwareId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateDecodingsoftwareWhere(IEnumerable<Decodingsoftware> decodingsoftwares)
        {
            if (!decodingsoftwares.Any()) return "1=1";
            else 
            {
                var idList = decodingsoftwares.Select(selectDecodingsoftware => String.Format("'{0}'", selectDecodingsoftware.DecodingsoftwareId));
                var csIdList = String.Join(",", idList);
                return String.Format("DecodingsoftwareId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Decodingsoftware> decodingsoftwares, string expandString)
        {
            
        }
        
    }
}