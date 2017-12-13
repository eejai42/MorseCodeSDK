using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Chart
    {
        private void InitPoco()
        {
            
            this.ChartId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ChartId")]
        public Guid ChartId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateChartWhere(IEnumerable<Chart> charts)
        {
            if (!charts.Any()) return "1=1";
            else 
            {
                var idList = charts.Select(selectChart => String.Format("'{0}'", selectChart.ChartId));
                var csIdList = String.Join(",", idList);
                return String.Format("ChartId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Chart> charts, string expandString)
        {
            
        }
        
    }
}