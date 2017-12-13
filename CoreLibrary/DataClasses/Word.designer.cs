using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Word
    {
        private void InitPoco()
        {
            
            this.WordId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "WordId")]
        public Guid WordId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateWordWhere(IEnumerable<Word> words)
        {
            if (!words.Any()) return "1=1";
            else 
            {
                var idList = words.Select(selectWord => String.Format("'{0}'", selectWord.WordId));
                var csIdList = String.Join(",", idList);
                return String.Format("WordId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Word> words, string expandString)
        {
            
        }
        
    }
}