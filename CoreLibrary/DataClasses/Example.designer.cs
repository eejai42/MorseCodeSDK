using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Example
    {
        private void InitPoco()
        {
            
            this.ExampleId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ExampleId")]
        public Guid ExampleId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateExampleWhere(IEnumerable<Example> examples)
        {
            if (!examples.Any()) return "1=1";
            else 
            {
                var idList = examples.Select(selectExample => String.Format("'{0}'", selectExample.ExampleId));
                var csIdList = String.Join(",", idList);
                return String.Format("ExampleId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Example> examples, string expandString)
        {
            
        }
        
    }
}