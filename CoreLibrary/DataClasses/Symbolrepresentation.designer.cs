using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Symbolrepresentation
    {
        private void InitPoco()
        {
            
            this.SymbolrepresentationId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SymbolrepresentationId")]
        public Guid SymbolrepresentationId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateSymbolrepresentationWhere(IEnumerable<Symbolrepresentation> symbolrepresentations)
        {
            if (!symbolrepresentations.Any()) return "1=1";
            else 
            {
                var idList = symbolrepresentations.Select(selectSymbolrepresentation => String.Format("'{0}'", selectSymbolrepresentation.SymbolrepresentationId));
                var csIdList = String.Join(",", idList);
                return String.Format("SymbolrepresentationId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Symbolrepresentation> symbolrepresentations, string expandString)
        {
            
        }
        
    }
}