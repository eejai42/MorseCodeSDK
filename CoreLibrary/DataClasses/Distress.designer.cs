using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Distress
    {
        private void InitPoco()
        {
            
            this.DistressId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DistressId")]
        public Guid DistressId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateDistressWhere(IEnumerable<Distress> distresses)
        {
            if (!distresses.Any()) return "1=1";
            else 
            {
                var idList = distresses.Select(selectDistress => String.Format("'{0}'", selectDistress.DistressId));
                var csIdList = String.Join(",", idList);
                return String.Format("DistressId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Distress> distresses, string expandString)
        {
            
        }
        
    }
}