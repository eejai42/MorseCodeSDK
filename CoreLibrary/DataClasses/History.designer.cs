using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class History
    {
        private void InitPoco()
        {
            
            this.HistoryId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HistoryId")]
        public Guid HistoryId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateHistoryWhere(IEnumerable<History> histories)
        {
            if (!histories.Any()) return "1=1";
            else 
            {
                var idList = histories.Select(selectHistory => String.Format("'{0}'", selectHistory.HistoryId));
                var csIdList = String.Join(",", idList);
                return String.Format("HistoryId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<History> histories, string expandString)
        {
            
        }
        
    }
}