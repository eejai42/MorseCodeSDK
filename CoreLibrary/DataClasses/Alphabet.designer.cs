using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Alphabet
    {
        private void InitPoco()
        {
            
            this.AlphabetId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AlphabetId")]
        public Guid AlphabetId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateAlphabetWhere(IEnumerable<Alphabet> alphabets)
        {
            if (!alphabets.Any()) return "1=1";
            else 
            {
                var idList = alphabets.Select(selectAlphabet => String.Format("'{0}'", selectAlphabet.AlphabetId));
                var csIdList = String.Join(",", idList);
                return String.Format("AlphabetId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Alphabet> alphabets, string expandString)
        {
            
        }
        
    }
}