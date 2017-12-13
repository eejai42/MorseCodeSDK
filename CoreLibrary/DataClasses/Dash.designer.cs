using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Dash
    {
        private void InitPoco()
        {
            
            this.DashId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DashId")]
        public Guid DashId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateDashWhere(IEnumerable<Dash> dashs)
        {
            if (!dashs.Any()) return "1=1";
            else 
            {
                var idList = dashs.Select(selectDash => String.Format("'{0}'", selectDash.DashId));
                var csIdList = String.Join(",", idList);
                return String.Format("DashId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Dash> dashs, string expandString)
        {
            
        }
        
    }
}