using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Jump
    {
        private void InitPoco()
        {
            
            this.JumpId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "JumpId")]
        public Guid JumpId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateJumpWhere(IEnumerable<Jump> jumps)
        {
            if (!jumps.Any()) return "1=1";
            else 
            {
                var idList = jumps.Select(selectJump => String.Format("'{0}'", selectJump.JumpId));
                var csIdList = String.Join(",", idList);
                return String.Format("JumpId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Jump> jumps, string expandString)
        {
            
        }
        
    }
}