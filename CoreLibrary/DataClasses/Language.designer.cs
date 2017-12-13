using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Language
    {
        private void InitPoco()
        {
            
            this.LanguageId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LanguageId")]
        public Guid LanguageId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateLanguageWhere(IEnumerable<Language> languages)
        {
            if (!languages.Any()) return "1=1";
            else 
            {
                var idList = languages.Select(selectLanguage => String.Format("'{0}'", selectLanguage.LanguageId));
                var csIdList = String.Join(",", idList);
                return String.Format("LanguageId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Language> languages, string expandString)
        {
            
        }
        
    }
}