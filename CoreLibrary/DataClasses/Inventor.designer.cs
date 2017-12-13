using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Inventor
    {
        private void InitPoco()
        {
            
            this.InventorId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InventorId")]
        public Guid InventorId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateInventorWhere(IEnumerable<Inventor> inventors)
        {
            if (!inventors.Any()) return "1=1";
            else 
            {
                var idList = inventors.Select(selectInventor => String.Format("'{0}'", selectInventor.InventorId));
                var csIdList = String.Join(",", idList);
                return String.Format("InventorId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Inventor> inventors, string expandString)
        {
            
        }
        
    }
}