using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Prosignsformorsecode
    {
        private void InitPoco()
        {
            
            this.ProsignsformorsecodeId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProsignsformorsecodeId")]
        public Guid ProsignsformorsecodeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateProsignsformorsecodeWhere(IEnumerable<Prosignsformorsecode> prosignsformorsecodes)
        {
            if (!prosignsformorsecodes.Any()) return "1=1";
            else 
            {
                var idList = prosignsformorsecodes.Select(selectProsignsformorsecode => String.Format("'{0}'", selectProsignsformorsecode.ProsignsformorsecodeId));
                var csIdList = String.Join(",", idList);
                return String.Format("ProsignsformorsecodeId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Prosignsformorsecode> prosignsformorsecodes, string expandString)
        {
            
        }
        
    }
}