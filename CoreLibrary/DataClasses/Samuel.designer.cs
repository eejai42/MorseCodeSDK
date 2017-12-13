using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Samuel
    {
        private void InitPoco()
        {
            
            this.SamuelId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SamuelId")]
        public Guid SamuelId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateSamuelWhere(IEnumerable<Samuel> samuels)
        {
            if (!samuels.Any()) return "1=1";
            else 
            {
                var idList = samuels.Select(selectSamuel => String.Format("'{0}'", selectSamuel.SamuelId));
                var csIdList = String.Join(",", idList);
                return String.Format("SamuelId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Samuel> samuels, string expandString)
        {
            
        }
        
    }
}