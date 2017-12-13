using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Time
    {
        private void InitPoco()
        {
            
            this.TimeId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TimeId")]
        public Guid TimeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateTimeWhere(IEnumerable<Time> times)
        {
            if (!times.Any()) return "1=1";
            else 
            {
                var idList = times.Select(selectTime => String.Format("'{0}'", selectTime.TimeId));
                var csIdList = String.Join(",", idList);
                return String.Format("TimeId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Time> times, string expandString)
        {
            
        }
        
    }
}