using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Isobasiclatinalphabet
    {
        private void InitPoco()
        {
            
            this.IsobasiclatinalphabetId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsobasiclatinalphabetId")]
        public Guid IsobasiclatinalphabetId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateIsobasiclatinalphabetWhere(IEnumerable<Isobasiclatinalphabet> isobasiclatinalphabets)
        {
            if (!isobasiclatinalphabets.Any()) return "1=1";
            else 
            {
                var idList = isobasiclatinalphabets.Select(selectIsobasiclatinalphabet => String.Format("'{0}'", selectIsobasiclatinalphabet.IsobasiclatinalphabetId));
                var csIdList = String.Join(",", idList);
                return String.Format("IsobasiclatinalphabetId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Isobasiclatinalphabet> isobasiclatinalphabets, string expandString)
        {
            
        }
        
    }
}