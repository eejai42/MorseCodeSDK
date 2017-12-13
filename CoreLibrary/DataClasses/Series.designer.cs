using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Series
    {
        private void InitPoco()
        {
            
            this.SeriesId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SeriesId")]
        public Guid SeriesId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateSeriesWhere(IEnumerable<Series> serieses)
        {
            if (!serieses.Any()) return "1=1";
            else 
            {
                var idList = serieses.Select(selectSeries => String.Format("'{0}'", selectSeries.SeriesId));
                var csIdList = String.Join(",", idList);
                return String.Format("SeriesId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Series> serieses, string expandString)
        {
            
        }
        
    }
}