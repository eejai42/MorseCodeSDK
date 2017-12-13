using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class International
    {
        private void InitPoco()
        {
            
            this.InternationalId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InternationalId")]
        public Guid InternationalId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateInternationalWhere(IEnumerable<International> internationals)
        {
            if (!internationals.Any()) return "1=1";
            else 
            {
                var idList = internationals.Select(selectInternational => String.Format("'{0}'", selectInternational.InternationalId));
                var csIdList = String.Join(",", idList);
                return String.Format("InternationalId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<International> internationals, string expandString)
        {
            
        }
        
    }
}