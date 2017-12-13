using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Extension
    {
        private void InitPoco()
        {
            
            this.ExtensionId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExtensionId")]
        public Guid ExtensionId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateExtensionWhere(IEnumerable<Extension> extensions)
        {
            if (!extensions.Any()) return "1=1";
            else 
            {
                var idList = extensions.Select(selectExtension => String.Format("'{0}'", selectExtension.ExtensionId));
                var csIdList = String.Join(",", idList);
                return String.Format("ExtensionId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Extension> extensions, string expandString)
        {
            
        }
        
    }
}