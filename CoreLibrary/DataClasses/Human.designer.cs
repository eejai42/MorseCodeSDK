using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Human
    {
        private void InitPoco()
        {
            
            this.HumanId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HumanId")]
        public Guid HumanId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateHumanWhere(IEnumerable<Human> humans)
        {
            if (!humans.Any()) return "1=1";
            else 
            {
                var idList = humans.Select(selectHuman => String.Format("'{0}'", selectHuman.HumanId));
                var csIdList = String.Join(",", idList);
                return String.Format("HumanId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Human> humans, string expandString)
        {
            
        }
        
    }
}