using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Understanding
    {
        private void InitPoco()
        {
            
            this.UnderstandingId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnderstandingId")]
        public Guid UnderstandingId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateUnderstandingWhere(IEnumerable<Understanding> understandings)
        {
            if (!understandings.Any()) return "1=1";
            else 
            {
                var idList = understandings.Select(selectUnderstanding => String.Format("'{0}'", selectUnderstanding.UnderstandingId));
                var csIdList = String.Join(",", idList);
                return String.Format("UnderstandingId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Understanding> understandings, string expandString)
        {
            
        }
        
    }
}