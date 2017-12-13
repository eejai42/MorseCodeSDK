using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Measurement
    {
        private void InitPoco()
        {
            
            this.MeasurementId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MeasurementId")]
        public Guid MeasurementId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateMeasurementWhere(IEnumerable<Measurement> measurements)
        {
            if (!measurements.Any()) return "1=1";
            else 
            {
                var idList = measurements.Select(selectMeasurement => String.Format("'{0}'", selectMeasurement.MeasurementId));
                var csIdList = String.Join(",", idList);
                return String.Format("MeasurementId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Measurement> measurements, string expandString)
        {
            
        }
        
    }
}