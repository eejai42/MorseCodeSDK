using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Frequency
    {
        private void InitPoco()
        {
            
            this.FrequencyId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FrequencyId")]
        public Guid FrequencyId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateFrequencyWhere(IEnumerable<Frequency> frequencies)
        {
            if (!frequencies.Any()) return "1=1";
            else 
            {
                var idList = frequencies.Select(selectFrequency => String.Format("'{0}'", selectFrequency.FrequencyId));
                var csIdList = String.Join(",", idList);
                return String.Format("FrequencyId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Frequency> frequencies, string expandString)
        {
            
        }
        
    }
}