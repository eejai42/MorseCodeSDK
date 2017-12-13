using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Prosignsformorsecodeandnonenglishvariant
    {
        private void InitPoco()
        {
            
            this.ProsignsformorsecodeandnonenglishvariantId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ProsignsformorsecodeandnonenglishvariantId")]
        public Guid ProsignsformorsecodeandnonenglishvariantId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateProsignsformorsecodeandnonenglishvariantWhere(IEnumerable<Prosignsformorsecodeandnonenglishvariant> prosignsformorsecodeandnonenglishvariants)
        {
            if (!prosignsformorsecodeandnonenglishvariants.Any()) return "1=1";
            else 
            {
                var idList = prosignsformorsecodeandnonenglishvariants.Select(selectProsignsformorsecodeandnonenglishvariant => String.Format("'{0}'", selectProsignsformorsecodeandnonenglishvariant.ProsignsformorsecodeandnonenglishvariantId));
                var csIdList = String.Join(",", idList);
                return String.Format("ProsignsformorsecodeandnonenglishvariantId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Prosignsformorsecodeandnonenglishvariant> prosignsformorsecodeandnonenglishvariants, string expandString)
        {
            
        }
        
    }
}