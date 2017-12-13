using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Voice
    {
        private void InitPoco()
        {
            
            this.VoiceId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "VoiceId")]
        public Guid VoiceId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateVoiceWhere(IEnumerable<Voice> voices)
        {
            if (!voices.Any()) return "1=1";
            else 
            {
                var idList = voices.Select(selectVoice => String.Format("'{0}'", selectVoice.VoiceId));
                var csIdList = String.Join(",", idList);
                return String.Format("VoiceId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Voice> voices, string expandString)
        {
            
        }
        
    }
}