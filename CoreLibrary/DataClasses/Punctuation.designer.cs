using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Punctuation
    {
        private void InitPoco()
        {
            
            this.PunctuationId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PunctuationId")]
        public Guid PunctuationId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreatePunctuationWhere(IEnumerable<Punctuation> punctuations)
        {
            if (!punctuations.Any()) return "1=1";
            else 
            {
                var idList = punctuations.Select(selectPunctuation => String.Format("'{0}'", selectPunctuation.PunctuationId));
                var csIdList = String.Join(",", idList);
                return String.Format("PunctuationId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Punctuation> punctuations, string expandString)
        {
            
        }
        
    }
}