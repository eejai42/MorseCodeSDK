using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Amateurradiolicense
    {
        private void InitPoco()
        {
            
            this.AmateurradiolicenseId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AmateurradiolicenseId")]
        public Guid AmateurradiolicenseId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateAmateurradiolicenseWhere(IEnumerable<Amateurradiolicense> amateurradiolicenses)
        {
            if (!amateurradiolicenses.Any()) return "1=1";
            else 
            {
                var idList = amateurradiolicenses.Select(selectAmateurradiolicense => String.Format("'{0}'", selectAmateurradiolicense.AmateurradiolicenseId));
                var csIdList = String.Join(",", idList);
                return String.Format("AmateurradiolicenseId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Amateurradiolicense> amateurradiolicenses, string expandString)
        {
            
        }
        
    }
}