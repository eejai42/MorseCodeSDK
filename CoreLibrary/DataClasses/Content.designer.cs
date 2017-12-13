using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Content
    {
        private void InitPoco()
        {
            
            this.ContentId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ContentId")]
        public Guid ContentId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateContentWhere(IEnumerable<Content> contents)
        {
            if (!contents.Any()) return "1=1";
            else 
            {
                var idList = contents.Select(selectContent => String.Format("'{0}'", selectContent.ContentId));
                var csIdList = String.Join(",", idList);
                return String.Format("ContentId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Content> contents, string expandString)
        {
            
        }
        
    }
}