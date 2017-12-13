using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Information
    {
        private void InitPoco()
        {
            
            this.InformationId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "InformationId")]
        public Guid InformationId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateInformationWhere(IEnumerable<Information> informations)
        {
            if (!informations.Any()) return "1=1";
            else 
            {
                var idList = informations.Select(selectInformation => String.Format("'{0}'", selectInformation.InformationId));
                var csIdList = String.Join(",", idList);
                return String.Format("InformationId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Information> informations, string expandString)
        {
            
        }
        
    }
}