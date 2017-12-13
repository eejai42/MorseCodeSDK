using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Signal
    {
        private void InitPoco()
        {
            
            this.SignalId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SignalId")]
        public Guid SignalId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateSignalWhere(IEnumerable<Signal> signals)
        {
            if (!signals.Any()) return "1=1";
            else 
            {
                var idList = signals.Select(selectSignal => String.Format("'{0}'", selectSignal.SignalId));
                var csIdList = String.Join(",", idList);
                return String.Format("SignalId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Signal> signals, string expandString)
        {
            
        }
        
    }
}