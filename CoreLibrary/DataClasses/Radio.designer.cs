using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Radio
    {
        private void InitPoco()
        {
            
            this.RadioId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RadioId")]
        public Guid RadioId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateRadioWhere(IEnumerable<Radio> radios)
        {
            if (!radios.Any()) return "1=1";
            else 
            {
                var idList = radios.Select(selectRadio => String.Format("'{0}'", selectRadio.RadioId));
                var csIdList = String.Join(",", idList);
                return String.Format("RadioId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Radio> radios, string expandString)
        {
            
        }
        
    }
}