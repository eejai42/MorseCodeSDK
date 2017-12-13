using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Andspeed
    {
        private void InitPoco()
        {
            
            this.AndspeedId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AndspeedId")]
        public Guid AndspeedId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateAndspeedWhere(IEnumerable<Andspeed> andspeeds)
        {
            if (!andspeeds.Any()) return "1=1";
            else 
            {
                var idList = andspeeds.Select(selectAndspeed => String.Format("'{0}'", selectAndspeed.AndspeedId));
                var csIdList = String.Join(",", idList);
                return String.Format("AndspeedId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Andspeed> andspeeds, string expandString)
        {
            
        }
        
    }
}