using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Unit
    {
        private void InitPoco()
        {
            
            this.UnitId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UnitId")]
        public Guid UnitId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateUnitWhere(IEnumerable<Unit> units)
        {
            if (!units.Any()) return "1=1";
            else 
            {
                var idList = units.Select(selectUnit => String.Format("'{0}'", selectUnit.UnitId));
                var csIdList = String.Join(",", idList);
                return String.Format("UnitId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Unit> units, string expandString)
        {
            
        }
        
    }
}