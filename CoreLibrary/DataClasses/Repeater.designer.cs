using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Repeater
    {
        private void InitPoco()
        {
            
            this.RepeaterId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RepeaterId")]
        public Guid RepeaterId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateRepeaterWhere(IEnumerable<Repeater> repeaters)
        {
            if (!repeaters.Any()) return "1=1";
            else 
            {
                var idList = repeaters.Select(selectRepeater => String.Format("'{0}'", selectRepeater.RepeaterId));
                var csIdList = String.Join(",", idList);
                return String.Format("RepeaterId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Repeater> repeaters, string expandString)
        {
            
        }
        
    }
}