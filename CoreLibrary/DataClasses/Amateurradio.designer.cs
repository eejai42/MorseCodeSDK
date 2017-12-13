using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Amateurradio
    {
        private void InitPoco()
        {
            
            this.AmateurradioId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AmateurradioId")]
        public Guid AmateurradioId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateAmateurradioWhere(IEnumerable<Amateurradio> amateurradios)
        {
            if (!amateurradios.Any()) return "1=1";
            else 
            {
                var idList = amateurradios.Select(selectAmateurradio => String.Format("'{0}'", selectAmateurradio.AmateurradioId));
                var csIdList = String.Join(",", idList);
                return String.Format("AmateurradioId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Amateurradio> amateurradios, string expandString)
        {
            
        }
        
    }
}