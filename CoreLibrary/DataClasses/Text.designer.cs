using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Text
    {
        private void InitPoco()
        {
            
            this.TextId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TextId")]
        public Guid TextId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateTextWhere(IEnumerable<Text> texts)
        {
            if (!texts.Any()) return "1=1";
            else 
            {
                var idList = texts.Select(selectText => String.Format("'{0}'", selectText.TextId));
                var csIdList = String.Join(",", idList);
                return String.Format("TextId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Text> texts, string expandString)
        {
            
        }
        
    }
}