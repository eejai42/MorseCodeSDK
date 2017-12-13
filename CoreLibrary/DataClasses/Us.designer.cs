using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Us
    {
        private void InitPoco()
        {
            
            this.UsId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UsId")]
        public Guid UsId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateUsWhere(IEnumerable<Us> uses)
        {
            if (!uses.Any()) return "1=1";
            else 
            {
                var idList = uses.Select(selectUs => String.Format("'{0}'", selectUs.UsId));
                var csIdList = String.Join(",", idList);
                return String.Format("UsId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Us> uses, string expandString)
        {
            
        }
        
    }
}