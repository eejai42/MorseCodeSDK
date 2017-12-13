using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Spokenrepresentation
    {
        private void InitPoco()
        {
            
            this.SpokenrepresentationId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SpokenrepresentationId")]
        public Guid SpokenrepresentationId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateSpokenrepresentationWhere(IEnumerable<Spokenrepresentation> spokenrepresentations)
        {
            if (!spokenrepresentations.Any()) return "1=1";
            else 
            {
                var idList = spokenrepresentations.Select(selectSpokenrepresentation => String.Format("'{0}'", selectSpokenrepresentation.SpokenrepresentationId));
                var csIdList = String.Join(",", idList);
                return String.Format("SpokenrepresentationId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Spokenrepresentation> spokenrepresentations, string expandString)
        {
            
        }
        
    }
}