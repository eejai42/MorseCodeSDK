using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Speedinwordsperminute
    {
        private void InitPoco()
        {
            
            this.SpeedinwordsperminuteId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SpeedinwordsperminuteId")]
        public Guid SpeedinwordsperminuteId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateSpeedinwordsperminuteWhere(IEnumerable<Speedinwordsperminute> speedinwordsperminutes)
        {
            if (!speedinwordsperminutes.Any()) return "1=1";
            else 
            {
                var idList = speedinwordsperminutes.Select(selectSpeedinwordsperminute => String.Format("'{0}'", selectSpeedinwordsperminute.SpeedinwordsperminuteId));
                var csIdList = String.Join(",", idList);
                return String.Format("SpeedinwordsperminuteId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Speedinwordsperminute> speedinwordsperminutes, string expandString)
        {
            
        }
        
    }
}