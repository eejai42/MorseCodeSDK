using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Nondirectionalbeacon
    {
        private void InitPoco()
        {
            
            this.NondirectionalbeaconId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NondirectionalbeaconId")]
        public Guid NondirectionalbeaconId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateNondirectionalbeaconWhere(IEnumerable<Nondirectionalbeacon> nondirectionalbeacons)
        {
            if (!nondirectionalbeacons.Any()) return "1=1";
            else 
            {
                var idList = nondirectionalbeacons.Select(selectNondirectionalbeacon => String.Format("'{0}'", selectNondirectionalbeacon.NondirectionalbeaconId));
                var csIdList = String.Join(",", idList);
                return String.Format("NondirectionalbeaconId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Nondirectionalbeacon> nondirectionalbeacons, string expandString)
        {
            
        }
        
    }
}