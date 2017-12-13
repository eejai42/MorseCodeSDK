using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Code
    {
        private void InitPoco()
        {
            
            this.CodeId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CodeId")]
        public Guid CodeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateCodeWhere(IEnumerable<Code> codes)
        {
            if (!codes.Any()) return "1=1";
            else 
            {
                var idList = codes.Select(selectCode => String.Format("'{0}'", selectCode.CodeId));
                var csIdList = String.Join(",", idList);
                return String.Format("CodeId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Code> codes, string expandString)
        {
            
        }
        
    }
}