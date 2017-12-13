using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Representation
    {
        private void InitPoco()
        {
            
            this.RepresentationId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RepresentationId")]
        public Guid RepresentationId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateRepresentationWhere(IEnumerable<Representation> representations)
        {
            if (!representations.Any()) return "1=1";
            else 
            {
                var idList = representations.Select(selectRepresentation => String.Format("'{0}'", selectRepresentation.RepresentationId));
                var csIdList = String.Join(",", idList);
                return String.Format("RepresentationId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Representation> representations, string expandString)
        {
            
        }
        
    }
}