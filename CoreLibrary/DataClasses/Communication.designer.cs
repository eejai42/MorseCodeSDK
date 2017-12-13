using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Communication
    {
        private void InitPoco()
        {
            
            this.CommunicationId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CommunicationId")]
        public Guid CommunicationId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateCommunicationWhere(IEnumerable<Communication> communications)
        {
            if (!communications.Any()) return "1=1";
            else 
            {
                var idList = communications.Select(selectCommunication => String.Format("'{0}'", selectCommunication.CommunicationId));
                var csIdList = String.Join(",", idList);
                return String.Format("CommunicationId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Communication> communications, string expandString)
        {
            
        }
        
    }
}