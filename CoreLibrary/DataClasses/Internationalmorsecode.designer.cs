using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Internationalmorsecode
    {
        private void InitPoco()
        {
            
            this.InternationalmorsecodeId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InternationalmorsecodeId")]
        public Guid InternationalmorsecodeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateInternationalmorsecodeWhere(IEnumerable<Internationalmorsecode> internationalmorsecodes)
        {
            if (!internationalmorsecodes.Any()) return "1=1";
            else 
            {
                var idList = internationalmorsecodes.Select(selectInternationalmorsecode => String.Format("'{0}'", selectInternationalmorsecode.InternationalmorsecodeId));
                var csIdList = String.Join(",", idList);
                return String.Format("InternationalmorsecodeId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Internationalmorsecode> internationalmorsecodes, string expandString)
        {
            
        }
        
    }
}