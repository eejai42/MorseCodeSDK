using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Development
    {
        private void InitPoco()
        {
            
            this.DevelopmentId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DevelopmentId")]
        public Guid DevelopmentId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateDevelopmentWhere(IEnumerable<Development> developments)
        {
            if (!developments.Any()) return "1=1";
            else 
            {
                var idList = developments.Select(selectDevelopment => String.Format("'{0}'", selectDevelopment.DevelopmentId));
                var csIdList = String.Join(",", idList);
                return String.Format("DevelopmentId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Development> developments, string expandString)
        {
            
        }
        
    }
}