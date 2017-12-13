using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Unusualvariant
    {
        private void InitPoco()
        {
            
            this.UnusualvariantId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnusualvariantId")]
        public Guid UnusualvariantId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateUnusualvariantWhere(IEnumerable<Unusualvariant> unusualvariants)
        {
            if (!unusualvariants.Any()) return "1=1";
            else 
            {
                var idList = unusualvariants.Select(selectUnusualvariant => String.Format("'{0}'", selectUnusualvariant.UnusualvariantId));
                var csIdList = String.Join(",", idList);
                return String.Format("UnusualvariantId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Unusualvariant> unusualvariants, string expandString)
        {
            
        }
        
    }
}