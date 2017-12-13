using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Alternative
    {
        private void InitPoco()
        {
            
            this.AlternativeId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AlternativeId")]
        public Guid AlternativeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateAlternativeWhere(IEnumerable<Alternative> alternatives)
        {
            if (!alternatives.Any()) return "1=1";
            else 
            {
                var idList = alternatives.Select(selectAlternative => String.Format("'{0}'", selectAlternative.AlternativeId));
                var csIdList = String.Join(",", idList);
                return String.Format("AlternativeId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Alternative> alternatives, string expandString)
        {
            
        }
        
    }
}