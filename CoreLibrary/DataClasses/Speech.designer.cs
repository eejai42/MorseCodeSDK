using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Speech
    {
        private void InitPoco()
        {
            
            this.SpeechId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SpeechId")]
        public Guid SpeechId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateSpeechWhere(IEnumerable<Speech> speechs)
        {
            if (!speechs.Any()) return "1=1";
            else 
            {
                var idList = speechs.Select(selectSpeech => String.Format("'{0}'", selectSpeech.SpeechId));
                var csIdList = String.Join(",", idList);
                return String.Format("SpeechId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Speech> speechs, string expandString)
        {
            
        }
        
    }
}