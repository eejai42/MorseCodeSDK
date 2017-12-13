using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Navigationalaid
    {
        private void InitPoco()
        {
            
            this.NavigationalaidId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NavigationalaidId")]
        public Guid NavigationalaidId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateNavigationalaidWhere(IEnumerable<Navigationalaid> navigationalaids)
        {
            if (!navigationalaids.Any()) return "1=1";
            else 
            {
                var idList = navigationalaids.Select(selectNavigationalaid => String.Format("'{0}'", selectNavigationalaid.NavigationalaidId));
                var csIdList = String.Join(",", idList);
                return String.Format("NavigationalaidId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Navigationalaid> navigationalaids, string expandString)
        {
            
        }
        
    }
}