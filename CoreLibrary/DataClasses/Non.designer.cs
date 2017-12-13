using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Non
    {
        private void InitPoco()
        {
            
            this.NonId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NonId")]
        public Guid NonId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateNonWhere(IEnumerable<Non> nons)
        {
            if (!nons.Any()) return "1=1";
            else 
            {
                var idList = nons.Select(selectNon => String.Format("'{0}'", selectNon.NonId));
                var csIdList = String.Join(",", idList);
                return String.Format("NonId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Non> nons, string expandString)
        {
            
        }
        
    }
}