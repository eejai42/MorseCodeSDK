using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Farnsworth
    {
        private void InitPoco()
        {
            
            this.FarnsworthId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FarnsworthId")]
        public Guid FarnsworthId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateFarnsworthWhere(IEnumerable<Farnsworth> farnsworths)
        {
            if (!farnsworths.Any()) return "1=1";
            else 
            {
                var idList = farnsworths.Select(selectFarnsworth => String.Format("'{0}'", selectFarnsworth.FarnsworthId));
                var csIdList = String.Join(",", idList);
                return String.Format("FarnsworthId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Farnsworth> farnsworths, string expandString)
        {
            
        }
        
    }
}