using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Encyclopedia
    {
        private void InitPoco()
        {
            
            this.EncyclopediaId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "EncyclopediaId")]
        public Guid EncyclopediaId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateEncyclopediaWhere(IEnumerable<Encyclopedia> encyclopedias)
        {
            if (!encyclopedias.Any()) return "1=1";
            else 
            {
                var idList = encyclopedias.Select(selectEncyclopedia => String.Format("'{0}'", selectEncyclopedia.EncyclopediaId));
                var csIdList = String.Join(",", idList);
                return String.Format("EncyclopediaId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Encyclopedia> encyclopedias, string expandString)
        {
            
        }
        
    }
}