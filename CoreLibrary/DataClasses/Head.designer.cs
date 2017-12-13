using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Head
    {
        private void InitPoco()
        {
            
            this.HeadId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HeadId")]
        public Guid HeadId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateHeadWhere(IEnumerable<Head> heads)
        {
            if (!heads.Any()) return "1=1";
            else 
            {
                var idList = heads.Select(selectHead => String.Format("'{0}'", selectHead.HeadId));
                var csIdList = String.Join(",", idList);
                return String.Format("HeadId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Head> heads, string expandString)
        {
            
        }
        
    }
}