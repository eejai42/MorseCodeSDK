using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Letter
    {
        private void InitPoco()
        {
            
            this.LetterId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LetterId")]
        public Guid LetterId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateLetterWhere(IEnumerable<Letter> letters)
        {
            if (!letters.Any()) return "1=1";
            else 
            {
                var idList = letters.Select(selectLetter => String.Format("'{0}'", selectLetter.LetterId));
                var csIdList = String.Join(",", idList);
                return String.Format("LetterId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Letter> letters, string expandString)
        {
            
        }
        
    }
}