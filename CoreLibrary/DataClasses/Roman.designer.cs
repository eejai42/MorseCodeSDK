using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Roman
    {
        private void InitPoco()
        {
            
            this.RomanId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RomanId")]
        public Guid RomanId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateRomanWhere(IEnumerable<Roman> romans)
        {
            if (!romans.Any()) return "1=1";
            else 
            {
                var idList = romans.Select(selectRoman => String.Format("'{0}'", selectRoman.RomanId));
                var csIdList = String.Join(",", idList);
                return String.Format("RomanId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Roman> romans, string expandString)
        {
            
        }
        
    }
}