using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Morsecodeasanassistivetechnology
    {
        private void InitPoco()
        {
            
            this.MorsecodeasanassistivetechnologyId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MorsecodeasanassistivetechnologyId")]
        public Guid MorsecodeasanassistivetechnologyId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateMorsecodeasanassistivetechnologyWhere(IEnumerable<Morsecodeasanassistivetechnology> morsecodeasanassistivetechnologies)
        {
            if (!morsecodeasanassistivetechnologies.Any()) return "1=1";
            else 
            {
                var idList = morsecodeasanassistivetechnologies.Select(selectMorsecodeasanassistivetechnology => String.Format("'{0}'", selectMorsecodeasanassistivetechnology.MorsecodeasanassistivetechnologyId));
                var csIdList = String.Join(",", idList);
                return String.Format("MorsecodeasanassistivetechnologyId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Morsecodeasanassistivetechnology> morsecodeasanassistivetechnologies, string expandString)
        {
            
        }
        
    }
}