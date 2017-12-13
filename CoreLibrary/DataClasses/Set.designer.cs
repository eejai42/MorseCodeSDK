using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Set
    {
        private void InitPoco()
        {
            
            this.SetId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SetId")]
        public Guid SetId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateSetWhere(IEnumerable<Set> sets)
        {
            if (!sets.Any()) return "1=1";
            else 
            {
                var idList = sets.Select(selectSet => String.Format("'{0}'", selectSet.SetId));
                var csIdList = String.Join(",", idList);
                return String.Format("SetId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Set> sets, string expandString)
        {
            
        }
        
    }
}