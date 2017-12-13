using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Decoding
    {
        private void InitPoco()
        {
            
            this.DecodingId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DecodingId")]
        public Guid DecodingId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateDecodingWhere(IEnumerable<Decoding> decodings)
        {
            if (!decodings.Any()) return "1=1";
            else 
            {
                var idList = decodings.Select(selectDecoding => String.Format("'{0}'", selectDecoding.DecodingId));
                var csIdList = String.Join(",", idList);
                return String.Format("DecodingId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Decoding> decodings, string expandString)
        {
            
        }
        
    }
}