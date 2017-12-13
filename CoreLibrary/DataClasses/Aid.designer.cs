using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Aid
    {
        private void InitPoco()
        {
            
            this.AidId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AidId")]
        public Guid AidId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateAidWhere(IEnumerable<Aid> aids)
        {
            if (!aids.Any()) return "1=1";
            else 
            {
                var idList = aids.Select(selectAid => String.Format("'{0}'", selectAid.AidId));
                var csIdList = String.Join(",", idList);
                return String.Format("AidId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Aid> aids, string expandString)
        {
            
        }
        
    }
}