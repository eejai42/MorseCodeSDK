using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Technology
    {
        private void InitPoco()
        {
            
            this.TechnologyId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TechnologyId")]
        public Guid TechnologyId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateTechnologyWhere(IEnumerable<Technology> technologies)
        {
            if (!technologies.Any()) return "1=1";
            else 
            {
                var idList = technologies.Select(selectTechnology => String.Format("'{0}'", selectTechnology.TechnologyId));
                var csIdList = String.Join(",", idList);
                return String.Format("TechnologyId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Technology> technologies, string expandString)
        {
            
        }
        
    }
}