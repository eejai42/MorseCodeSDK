using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Cablecode
    {
        private void InitPoco()
        {
            
            this.CablecodeId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CablecodeId")]
        public Guid CablecodeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateCablecodeWhere(IEnumerable<Cablecode> cablecodes)
        {
            if (!cablecodes.Any()) return "1=1";
            else 
            {
                var idList = cablecodes.Select(selectCablecode => String.Format("'{0}'", selectCablecode.CablecodeId));
                var csIdList = String.Join(",", idList);
                return String.Format("CablecodeId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Cablecode> cablecodes, string expandString)
        {
            
        }
        
    }
}