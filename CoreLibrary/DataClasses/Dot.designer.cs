using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Dot
    {
        private void InitPoco()
        {
            
            this.DotId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DotId")]
        public Guid DotId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateDotWhere(IEnumerable<Dot> dots)
        {
            if (!dots.Any()) return "1=1";
            else 
            {
                var idList = dots.Select(selectDot => String.Format("'{0}'", selectDot.DotId));
                var csIdList = String.Join(",", idList);
                return String.Format("DotId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Dot> dots, string expandString)
        {
            
        }
        
    }
}