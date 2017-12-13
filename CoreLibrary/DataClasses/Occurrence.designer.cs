using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Occurrence
    {
        private void InitPoco()
        {
            
            this.OccurrenceId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OccurrenceId")]
        public Guid OccurrenceId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateOccurrenceWhere(IEnumerable<Occurrence> occurrences)
        {
            if (!occurrences.Any()) return "1=1";
            else 
            {
                var idList = occurrences.Select(selectOccurrence => String.Format("'{0}'", selectOccurrence.OccurrenceId));
                var csIdList = String.Join(",", idList);
                return String.Format("OccurrenceId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Occurrence> occurrences, string expandString)
        {
            
        }
        
    }
}