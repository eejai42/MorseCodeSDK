using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Entropyencoding
    {
        private void InitPoco()
        {
            
            this.EntropyencodingId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "EntropyencodingId")]
        public Guid EntropyencodingId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateEntropyencodingWhere(IEnumerable<Entropyencoding> entropyencodings)
        {
            if (!entropyencodings.Any()) return "1=1";
            else 
            {
                var idList = entropyencodings.Select(selectEntropyencoding => String.Format("'{0}'", selectEntropyencoding.EntropyencodingId));
                var csIdList = String.Join(",", idList);
                return String.Format("EntropyencodingId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Entropyencoding> entropyencodings, string expandString)
        {
            
        }
        
    }
}