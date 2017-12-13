using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Reference
    {
        private void InitPoco()
        {
            
            this.ReferenceId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ReferenceId")]
        public Guid ReferenceId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateReferenceWhere(IEnumerable<Reference> references)
        {
            if (!references.Any()) return "1=1";
            else 
            {
                var idList = references.Select(selectReference => String.Format("'{0}'", selectReference.ReferenceId));
                var csIdList = String.Join(",", idList);
                return String.Format("ReferenceId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Reference> references, string expandString)
        {
            
        }
        
    }
}