using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Telecommunication
    {
        private void InitPoco()
        {
            
            this.TelecommunicationId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TelecommunicationId")]
        public Guid TelecommunicationId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateTelecommunicationWhere(IEnumerable<Telecommunication> telecommunications)
        {
            if (!telecommunications.Any()) return "1=1";
            else 
            {
                var idList = telecommunications.Select(selectTelecommunication => String.Format("'{0}'", selectTelecommunication.TelecommunicationId));
                var csIdList = String.Join(",", idList);
                return String.Format("TelecommunicationId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Telecommunication> telecommunications, string expandString)
        {
            
        }
        
    }
}