using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Otheru
    {
        private void InitPoco()
        {
            
            this.OtheruId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OtheruId")]
        public Guid OtheruId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateOtheruWhere(IEnumerable<Otheru> otherus)
        {
            if (!otherus.Any()) return "1=1";
            else 
            {
                var idList = otherus.Select(selectOtheru => String.Format("'{0}'", selectOtheru.OtheruId));
                var csIdList = String.Join(",", idList);
                return String.Format("OtheruId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Otheru> otherus, string expandString)
        {
            
        }
        
    }
}