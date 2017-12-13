using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Iso
    {
        private void InitPoco()
        {
            
            this.IsoId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsoId")]
        public Guid IsoId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateIsoWhere(IEnumerable<Iso> isos)
        {
            if (!isos.Any()) return "1=1";
            else 
            {
                var idList = isos.Select(selectIso => String.Format("'{0}'", selectIso.IsoId));
                var csIdList = String.Join(",", idList);
                return String.Format("IsoId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Iso> isos, string expandString)
        {
            
        }
        
    }
}