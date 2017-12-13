using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class English
    {
        private void InitPoco()
        {
            
            this.EnglishId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "EnglishId")]
        public Guid EnglishId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateEnglishWhere(IEnumerable<English> englishs)
        {
            if (!englishs.Any()) return "1=1";
            else 
            {
                var idList = englishs.Select(selectEnglish => String.Format("'{0}'", selectEnglish.EnglishId));
                var csIdList = String.Join(",", idList);
                return String.Format("EnglishId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<English> englishs, string expandString)
        {
            
        }
        
    }
}