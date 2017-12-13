using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Amateurradiorepeater
    {
        private void InitPoco()
        {
            
            this.AmateurradiorepeaterId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AmateurradiorepeaterId")]
        public Guid AmateurradiorepeaterId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateAmateurradiorepeaterWhere(IEnumerable<Amateurradiorepeater> amateurradiorepeaters)
        {
            if (!amateurradiorepeaters.Any()) return "1=1";
            else 
            {
                var idList = amateurradiorepeaters.Select(selectAmateurradiorepeater => String.Format("'{0}'", selectAmateurradiorepeater.AmateurradiorepeaterId));
                var csIdList = String.Join(",", idList);
                return String.Format("AmateurradiorepeaterId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Amateurradiorepeater> amateurradiorepeaters, string expandString)
        {
            
        }
        
    }
}