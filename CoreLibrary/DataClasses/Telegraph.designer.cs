using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Telegraph
    {
        private void InitPoco()
        {
            
            this.TelegraphId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TelegraphId")]
        public Guid TelegraphId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateTelegraphWhere(IEnumerable<Telegraph> telegraphs)
        {
            if (!telegraphs.Any()) return "1=1";
            else 
            {
                var idList = telegraphs.Select(selectTelegraph => String.Format("'{0}'", selectTelegraph.TelegraphId));
                var csIdList = String.Join(",", idList);
                return String.Format("TelegraphId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Telegraph> telegraphs, string expandString)
        {
            
        }
        
    }
}