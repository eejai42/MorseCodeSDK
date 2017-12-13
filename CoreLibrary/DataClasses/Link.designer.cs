using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Link
    {
        private void InitPoco()
        {
            
            this.LinkId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LinkId")]
        public Guid LinkId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateLinkWhere(IEnumerable<Link> links)
        {
            if (!links.Any()) return "1=1";
            else 
            {
                var idList = links.Select(selectLink => String.Format("'{0}'", selectLink.LinkId));
                var csIdList = String.Join(",", idList);
                return String.Format("LinkId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Link> links, string expandString)
        {
            
        }
        
    }
}