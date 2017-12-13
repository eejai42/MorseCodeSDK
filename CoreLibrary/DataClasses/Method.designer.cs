using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Method
    {
        private void InitPoco()
        {
            
            this.MethodId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MethodId")]
        public Guid MethodId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateMethodWhere(IEnumerable<Method> methods)
        {
            if (!methods.Any()) return "1=1";
            else 
            {
                var idList = methods.Select(selectMethod => String.Format("'{0}'", selectMethod.MethodId));
                var csIdList = String.Join(",", idList);
                return String.Format("MethodId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Method> methods, string expandString)
        {
            
        }
        
    }
}