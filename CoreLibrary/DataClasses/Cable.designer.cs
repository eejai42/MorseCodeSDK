using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Cable
    {
        private void InitPoco()
        {
            
            this.CableId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CableId")]
        public Guid CableId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateCableWhere(IEnumerable<Cable> cables)
        {
            if (!cables.Any()) return "1=1";
            else 
            {
                var idList = cables.Select(selectCable => String.Format("'{0}'", selectCable.CableId));
                var csIdList = String.Join(",", idList);
                return String.Format("CableId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Cable> cables, string expandString)
        {
            
        }
        
    }
}