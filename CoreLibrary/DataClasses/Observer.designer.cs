using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Observer
    {
        private void InitPoco()
        {
            
            this.ObserverId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ObserverId")]
        public Guid ObserverId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateObserverWhere(IEnumerable<Observer> observers)
        {
            if (!observers.Any()) return "1=1";
            else 
            {
                var idList = observers.Select(selectObserver => String.Format("'{0}'", selectObserver.ObserverId));
                var csIdList = String.Join(",", idList);
                return String.Format("ObserverId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Observer> observers, string expandString)
        {
            
        }
        
    }
}