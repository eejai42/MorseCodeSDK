using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Alternativedisplayofcommoncharactersininternationalmorsecode
    {
        private void InitPoco()
        {
            
            this.AlternativedisplayofcommoncharactersininternationalmorsecodeId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AlternativedisplayofcommoncharactersininternationalmorsecodeId")]
        public Guid AlternativedisplayofcommoncharactersininternationalmorsecodeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateAlternativedisplayofcommoncharactersininternationalmorsecodeWhere(IEnumerable<Alternativedisplayofcommoncharactersininternationalmorsecode> alternativedisplayofcommoncharactersininternationalmorsecodes)
        {
            if (!alternativedisplayofcommoncharactersininternationalmorsecodes.Any()) return "1=1";
            else 
            {
                var idList = alternativedisplayofcommoncharactersininternationalmorsecodes.Select(selectAlternativedisplayofcommoncharactersininternationalmorsecode => String.Format("'{0}'", selectAlternativedisplayofcommoncharactersininternationalmorsecode.AlternativedisplayofcommoncharactersininternationalmorsecodeId));
                var csIdList = String.Join(",", idList);
                return String.Format("AlternativedisplayofcommoncharactersininternationalmorsecodeId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Alternativedisplayofcommoncharactersininternationalmorsecode> alternativedisplayofcommoncharactersininternationalmorsecodes, string expandString)
        {
            
        }
        
    }
}