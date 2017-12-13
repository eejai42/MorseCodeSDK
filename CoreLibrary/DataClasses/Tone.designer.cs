using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Tone
    {
        private void InitPoco()
        {
            
            this.ToneId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ToneId")]
        public Guid ToneId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateToneWhere(IEnumerable<Tone> tones)
        {
            if (!tones.Any()) return "1=1";
            else 
            {
                var idList = tones.Select(selectTone => String.Format("'{0}'", selectTone.ToneId));
                var csIdList = String.Join(",", idList);
                return String.Format("ToneId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Tone> tones, string expandString)
        {
            
        }
        
    }
}