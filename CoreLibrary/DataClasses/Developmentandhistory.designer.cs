using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Developmentandhistory
    {
        private void InitPoco()
        {
            
            this.DevelopmentandhistoryId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DevelopmentandhistoryId")]
        public Guid DevelopmentandhistoryId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateDevelopmentandhistoryWhere(IEnumerable<Developmentandhistory> developmentandhistories)
        {
            if (!developmentandhistories.Any()) return "1=1";
            else 
            {
                var idList = developmentandhistories.Select(selectDevelopmentandhistory => String.Format("'{0}'", selectDevelopmentandhistory.DevelopmentandhistoryId));
                var csIdList = String.Join(",", idList);
                return String.Format("DevelopmentandhistoryId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Developmentandhistory> developmentandhistories, string expandString)
        {
            
        }
        
    }
}