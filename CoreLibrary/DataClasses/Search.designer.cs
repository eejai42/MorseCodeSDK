using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Search
    {
        private void InitPoco()
        {
            
            this.SearchId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SearchId")]
        public Guid SearchId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateSearchWhere(IEnumerable<Search> searchs)
        {
            if (!searchs.Any()) return "1=1";
            else 
            {
                var idList = searchs.Select(selectSearch => String.Format("'{0}'", selectSearch.SearchId));
                var csIdList = String.Join(",", idList);
                return String.Format("SearchId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Search> searchs, string expandString)
        {
            
        }
        
    }
}