using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Click
    {
        private void InitPoco()
        {
            
            this.ClickId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ClickId")]
        public Guid ClickId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateClickWhere(IEnumerable<Click> clicks)
        {
            if (!clicks.Any()) return "1=1";
            else 
            {
                var idList = clicks.Select(selectClick => String.Format("'{0}'", selectClick.ClickId));
                var csIdList = String.Join(",", idList);
                return String.Format("ClickId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Click> clicks, string expandString)
        {
            
        }
        
    }
}