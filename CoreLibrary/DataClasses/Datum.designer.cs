using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Datum
    {
        private void InitPoco()
        {
            
            this.DatumId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DatumId")]
        public Guid DatumId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateDatumWhere(IEnumerable<Datum> datums)
        {
            if (!datums.Any()) return "1=1";
            else 
            {
                var idList = datums.Select(selectDatum => String.Format("'{0}'", selectDatum.DatumId));
                var csIdList = String.Join(",", idList);
                return String.Format("DatumId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Datum> datums, string expandString)
        {
            
        }
        
    }
}