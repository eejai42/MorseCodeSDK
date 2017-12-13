using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Linkbudgetissue
    {
        private void InitPoco()
        {
            
            this.LinkbudgetissueId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LinkbudgetissueId")]
        public Guid LinkbudgetissueId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateLinkbudgetissueWhere(IEnumerable<Linkbudgetissue> linkbudgetissues)
        {
            if (!linkbudgetissues.Any()) return "1=1";
            else 
            {
                var idList = linkbudgetissues.Select(selectLinkbudgetissue => String.Format("'{0}'", selectLinkbudgetissue.LinkbudgetissueId));
                var csIdList = String.Join(",", idList);
                return String.Format("LinkbudgetissueId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Linkbudgetissue> linkbudgetissues, string expandString)
        {
            
        }
        
    }
}