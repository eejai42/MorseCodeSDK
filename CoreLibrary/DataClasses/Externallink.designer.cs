using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Externallink
    {
        private void InitPoco()
        {
            
            this.ExternallinkId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExternallinkId")]
        public Guid ExternallinkId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateExternallinkWhere(IEnumerable<Externallink> externallinks)
        {
            if (!externallinks.Any()) return "1=1";
            else 
            {
                var idList = externallinks.Select(selectExternallink => String.Format("'{0}'", selectExternallink.ExternallinkId));
                var csIdList = String.Join(",", idList);
                return String.Format("ExternallinkId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Externallink> externallinks, string expandString)
        {
            
        }
        
    }
}