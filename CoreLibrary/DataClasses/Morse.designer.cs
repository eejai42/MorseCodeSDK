using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Morse
    {
        private void InitPoco()
        {
            
            this.MorseId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MorseId")]
        public Guid MorseId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateMorseWhere(IEnumerable<Morse> morses)
        {
            if (!morses.Any()) return "1=1";
            else 
            {
                var idList = morses.Select(selectMorse => String.Format("'{0}'", selectMorse.MorseId));
                var csIdList = String.Join(",", idList);
                return String.Format("MorseId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Morse> morses, string expandString)
        {
            
        }
        
    }
}