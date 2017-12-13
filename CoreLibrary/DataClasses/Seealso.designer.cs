using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Seealso
    {
        private void InitPoco()
        {
            
            this.SeealsoId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SeealsoId")]
        public Guid SeealsoId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateSeealsoWhere(IEnumerable<Seealso> seealsos)
        {
            if (!seealsos.Any()) return "1=1";
            else 
            {
                var idList = seealsos.Select(selectSeealso => String.Format("'{0}'", selectSeealso.SeealsoId));
                var csIdList = String.Join(",", idList);
                return String.Format("SeealsoId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Seealso> seealsos, string expandString)
        {
            
        }
        
    }
}