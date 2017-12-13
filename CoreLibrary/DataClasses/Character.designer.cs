using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Character
    {
        private void InitPoco()
        {
            
            this.CharacterId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CharacterId")]
        public Guid CharacterId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateCharacterWhere(IEnumerable<Character> characters)
        {
            if (!characters.Any()) return "1=1";
            else 
            {
                var idList = characters.Select(selectCharacter => String.Format("'{0}'", selectCharacter.CharacterId));
                var csIdList = String.Join(",", idList);
                return String.Format("CharacterId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Character> characters, string expandString)
        {
            
        }
        
    }
}