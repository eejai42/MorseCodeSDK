using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Treaty
    {
        private void InitPoco()
        {
            
            this.TreatyId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TreatyId")]
        public Guid TreatyId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateTreatyWhere(IEnumerable<Treaty> treaties)
        {
            if (!treaties.Any()) return "1=1";
            else 
            {
                var idList = treaties.Select(selectTreaty => String.Format("'{0}'", selectTreaty.TreatyId));
                var csIdList = String.Join(",", idList);
                return String.Format("TreatyId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Treaty> treaties, string expandString)
        {
            
        }
        
    }
}