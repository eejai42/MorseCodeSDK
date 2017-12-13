using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Space
    {
        private void InitPoco()
        {
            
            this.SpaceId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SpaceId")]
        public Guid SpaceId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateSpaceWhere(IEnumerable<Space> spaces)
        {
            if (!spaces.Any()) return "1=1";
            else 
            {
                var idList = spaces.Select(selectSpace => String.Format("'{0}'", selectSpace.SpaceId));
                var csIdList = String.Join(",", idList);
                return String.Format("SpaceId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Space> spaces, string expandString)
        {
            
        }
        
    }
}