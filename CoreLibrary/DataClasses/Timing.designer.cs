using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Timing
    {
        private void InitPoco()
        {
            
            this.TimingId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TimingId")]
        public Guid TimingId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateTimingWhere(IEnumerable<Timing> timings)
        {
            if (!timings.Any()) return "1=1";
            else 
            {
                var idList = timings.Select(selectTiming => String.Format("'{0}'", selectTiming.TimingId));
                var csIdList = String.Join(",", idList);
                return String.Format("TimingId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Timing> timings, string expandString)
        {
            
        }
        
    }
}