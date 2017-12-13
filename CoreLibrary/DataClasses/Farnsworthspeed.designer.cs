using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Farnsworthspeed
    {
        private void InitPoco()
        {
            
            this.FarnsworthspeedId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FarnsworthspeedId")]
        public Guid FarnsworthspeedId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateFarnsworthspeedWhere(IEnumerable<Farnsworthspeed> farnsworthspeeds)
        {
            if (!farnsworthspeeds.Any()) return "1=1";
            else 
            {
                var idList = farnsworthspeeds.Select(selectFarnsworthspeed => String.Format("'{0}'", selectFarnsworthspeed.FarnsworthspeedId));
                var csIdList = String.Join(",", idList);
                return String.Format("FarnsworthspeedId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Farnsworthspeed> farnsworthspeeds, string expandString)
        {
            
        }
        
    }
}