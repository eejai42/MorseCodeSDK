using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Variant
    {
        private void InitPoco()
        {
            
            this.VariantId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "VariantId")]
        public Guid VariantId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateVariantWhere(IEnumerable<Variant> variants)
        {
            if (!variants.Any()) return "1=1";
            else 
            {
                var idList = variants.Select(selectVariant => String.Format("'{0}'", selectVariant.VariantId));
                var csIdList = String.Join(",", idList);
                return String.Format("VariantId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Variant> variants, string expandString)
        {
            
        }
        
    }
}