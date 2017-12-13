using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Vor
    {
        private void InitPoco()
        {
            
            this.VorId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "VorId")]
        public Guid VorId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateVorWhere(IEnumerable<Vor> vors)
        {
            if (!vors.Any()) return "1=1";
            else 
            {
                var idList = vors.Select(selectVor => String.Format("'{0}'", selectVor.VorId));
                var csIdList = String.Join(",", idList);
                return String.Format("VorId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Vor> vors, string expandString)
        {
            
        }
        
    }
}