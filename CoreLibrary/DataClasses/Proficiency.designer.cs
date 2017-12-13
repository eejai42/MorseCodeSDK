using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Proficiency
    {
        private void InitPoco()
        {
            
            this.ProficiencyId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProficiencyId")]
        public Guid ProficiencyId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateProficiencyWhere(IEnumerable<Proficiency> proficiencies)
        {
            if (!proficiencies.Any()) return "1=1";
            else 
            {
                var idList = proficiencies.Select(selectProficiency => String.Format("'{0}'", selectProficiency.ProficiencyId));
                var csIdList = String.Join(",", idList);
                return String.Format("ProficiencyId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Proficiency> proficiencies, string expandString)
        {
            
        }
        
    }
}