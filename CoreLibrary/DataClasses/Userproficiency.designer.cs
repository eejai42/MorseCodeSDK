using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Userproficiency
    {
        private void InitPoco()
        {
            
            this.UserproficiencyId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UserproficiencyId")]
        public Guid UserproficiencyId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateUserproficiencyWhere(IEnumerable<Userproficiency> userproficiencies)
        {
            if (!userproficiencies.Any()) return "1=1";
            else 
            {
                var idList = userproficiencies.Select(selectUserproficiency => String.Format("'{0}'", selectUserproficiency.UserproficiencyId));
                var csIdList = String.Join(",", idList);
                return String.Format("UserproficiencyId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Userproficiency> userproficiencies, string expandString)
        {
            
        }
        
    }
}