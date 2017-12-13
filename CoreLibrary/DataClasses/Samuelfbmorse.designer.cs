using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Samuelfbmorse
    {
        private void InitPoco()
        {
            
            this.SamuelfbmorseId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SamuelfbmorseId")]
        public Guid SamuelfbmorseId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateSamuelfbmorseWhere(IEnumerable<Samuelfbmorse> samuelfbmorses)
        {
            if (!samuelfbmorses.Any()) return "1=1";
            else 
            {
                var idList = samuelfbmorses.Select(selectSamuelfbmorse => String.Format("'{0}'", selectSamuelfbmorse.SamuelfbmorseId));
                var csIdList = String.Join(",", idList);
                return String.Format("SamuelfbmorseId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Samuelfbmorse> samuelfbmorses, string expandString)
        {
            
        }
        
    }
}