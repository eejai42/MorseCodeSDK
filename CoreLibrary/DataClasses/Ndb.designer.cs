using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Ndb
    {
        private void InitPoco()
        {
            
            this.NdbId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NdbId")]
        public Guid NdbId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateNdbWhere(IEnumerable<Ndb> ndbs)
        {
            if (!ndbs.Any()) return "1=1";
            else 
            {
                var idList = ndbs.Select(selectNdb => String.Format("'{0}'", selectNdb.NdbId));
                var csIdList = String.Join(",", idList);
                return String.Format("NdbId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Ndb> ndbs, string expandString)
        {
            
        }
        
    }
}