using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Prosign
    {
        private void InitPoco()
        {
            
            this.ProsignId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProsignId")]
        public Guid ProsignId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateProsignWhere(IEnumerable<Prosign> prosigns)
        {
            if (!prosigns.Any()) return "1=1";
            else 
            {
                var idList = prosigns.Select(selectProsign => String.Format("'{0}'", selectProsign.ProsignId));
                var csIdList = String.Join(",", idList);
                return String.Format("ProsignId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Prosign> prosigns, string expandString)
        {
            
        }
        
    }
}