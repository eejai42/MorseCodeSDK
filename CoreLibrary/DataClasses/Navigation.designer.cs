using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Navigation
    {
        private void InitPoco()
        {
            
            this.NavigationId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NavigationId")]
        public Guid NavigationId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateNavigationWhere(IEnumerable<Navigation> navigations)
        {
            if (!navigations.Any()) return "1=1";
            else 
            {
                var idList = navigations.Select(selectNavigation => String.Format("'{0}'", selectNavigation.NavigationId));
                var csIdList = String.Join(",", idList);
                return String.Format("NavigationId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Navigation> navigations, string expandString)
        {
            
        }
        
    }
}