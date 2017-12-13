using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Wikipedia
    {
        private void InitPoco()
        {
            
            this.WikipediaId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "WikipediaId")]
        public Guid WikipediaId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateWikipediaWhere(IEnumerable<Wikipedia> wikipedias)
        {
            if (!wikipedias.Any()) return "1=1";
            else 
            {
                var idList = wikipedias.Select(selectWikipedia => String.Format("'{0}'", selectWikipedia.WikipediaId));
                var csIdList = String.Join(",", idList);
                return String.Format("WikipediaId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Wikipedia> wikipedias, string expandString)
        {
            
        }
        
    }
}