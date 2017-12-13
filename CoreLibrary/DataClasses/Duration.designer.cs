using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Duration
    {
        private void InitPoco()
        {
            
            this.DurationId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DurationId")]
        public Guid DurationId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateDurationWhere(IEnumerable<Duration> durations)
        {
            if (!durations.Any()) return "1=1";
            else 
            {
                var idList = durations.Select(selectDuration => String.Format("'{0}'", selectDuration.DurationId));
                var csIdList = String.Join(",", idList);
                return String.Format("DurationId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Duration> durations, string expandString)
        {
            
        }
        
    }
}