using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Application
    {
        private void InitPoco()
        {
            
            this.ApplicationId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ApplicationId")]
        public Guid ApplicationId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateApplicationWhere(IEnumerable<Application> applications)
        {
            if (!applications.Any()) return "1=1";
            else 
            {
                var idList = applications.Select(selectApplication => String.Format("'{0}'", selectApplication.ApplicationId));
                var csIdList = String.Join(",", idList);
                return String.Format("ApplicationId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Application> applications, string expandString)
        {
            
        }
        
    }
}