using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Software
    {
        private void InitPoco()
        {
            
            this.SoftwareId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SoftwareId")]
        public Guid SoftwareId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateSoftwareWhere(IEnumerable<Software> softwares)
        {
            if (!softwares.Any()) return "1=1";
            else 
            {
                var idList = softwares.Select(selectSoftware => String.Format("'{0}'", selectSoftware.SoftwareId));
                var csIdList = String.Join(",", idList);
                return String.Format("SoftwareId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Software> softwares, string expandString)
        {
            
        }
        
    }
}