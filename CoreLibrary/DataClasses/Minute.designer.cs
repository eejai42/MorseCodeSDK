using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Minute
    {
        private void InitPoco()
        {
            
            this.MinuteId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MinuteId")]
        public Guid MinuteId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateMinuteWhere(IEnumerable<Minute> minutes)
        {
            if (!minutes.Any()) return "1=1";
            else 
            {
                var idList = minutes.Select(selectMinute => String.Format("'{0}'", selectMinute.MinuteId));
                var csIdList = String.Join(",", idList);
                return String.Format("MinuteId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Minute> minutes, string expandString)
        {
            
        }
        
    }
}