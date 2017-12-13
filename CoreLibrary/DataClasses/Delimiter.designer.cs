using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Delimiter
    {
        private void InitPoco()
        {
            
            this.DelimiterId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DelimiterId")]
        public Guid DelimiterId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateDelimiterWhere(IEnumerable<Delimiter> delimiters)
        {
            if (!delimiters.Any()) return "1=1";
            else 
            {
                var idList = delimiters.Select(selectDelimiter => String.Format("'{0}'", selectDelimiter.DelimiterId));
                var csIdList = String.Join(",", idList);
                return String.Format("DelimiterId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Delimiter> delimiters, string expandString)
        {
            
        }
        
    }
}