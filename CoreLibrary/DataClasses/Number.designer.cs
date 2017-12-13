using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Number
    {
        private void InitPoco()
        {
            
            this.NumberId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NumberId")]
        public Guid NumberId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateNumberWhere(IEnumerable<Number> numbers)
        {
            if (!numbers.Any()) return "1=1";
            else 
            {
                var idList = numbers.Select(selectNumber => String.Format("'{0}'", selectNumber.NumberId));
                var csIdList = String.Join(",", idList);
                return String.Format("NumberId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Number> numbers, string expandString)
        {
            
        }
        
    }
}