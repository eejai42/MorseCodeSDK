using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Silence
    {
        private void InitPoco()
        {
            
            this.SilenceId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SilenceId")]
        public Guid SilenceId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateSilenceWhere(IEnumerable<Silence> silences)
        {
            if (!silences.Any()) return "1=1";
            else 
            {
                var idList = silences.Select(selectSilence => String.Format("'{0}'", selectSilence.SilenceId));
                var csIdList = String.Join(",", idList);
                return String.Format("SilenceId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Silence> silences, string expandString)
        {
            
        }
        
    }
}