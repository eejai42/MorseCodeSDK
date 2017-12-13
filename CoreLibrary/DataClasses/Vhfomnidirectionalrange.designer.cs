using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Vhfomnidirectionalrange
    {
        private void InitPoco()
        {
            
            this.VhfomnidirectionalrangeId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "VhfomnidirectionalrangeId")]
        public Guid VhfomnidirectionalrangeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateVhfomnidirectionalrangeWhere(IEnumerable<Vhfomnidirectionalrange> vhfomnidirectionalranges)
        {
            if (!vhfomnidirectionalranges.Any()) return "1=1";
            else 
            {
                var idList = vhfomnidirectionalranges.Select(selectVhfomnidirectionalrange => String.Format("'{0}'", selectVhfomnidirectionalrange.VhfomnidirectionalrangeId));
                var csIdList = String.Join(",", idList);
                return String.Format("VhfomnidirectionalrangeId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Vhfomnidirectionalrange> vhfomnidirectionalranges, string expandString)
        {
            
        }
        
    }
}