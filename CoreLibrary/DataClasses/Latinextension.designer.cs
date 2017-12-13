using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Latinextension
    {
        private void InitPoco()
        {
            
            this.LatinextensionId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LatinextensionId")]
        public Guid LatinextensionId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateLatinextensionWhere(IEnumerable<Latinextension> latinextensions)
        {
            if (!latinextensions.Any()) return "1=1";
            else 
            {
                var idList = latinextensions.Select(selectLatinextension => String.Format("'{0}'", selectLatinextension.LatinextensionId));
                var csIdList = String.Join(",", idList);
                return String.Format("LatinextensionId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Latinextension> latinextensions, string expandString)
        {
            
        }
        
    }
}