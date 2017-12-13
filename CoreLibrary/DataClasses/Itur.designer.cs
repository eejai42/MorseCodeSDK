using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Itur
    {
        private void InitPoco()
        {
            
            this.IturId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IturId")]
        public Guid IturId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateIturWhere(IEnumerable<Itur> iturs)
        {
            if (!iturs.Any()) return "1=1";
            else 
            {
                var idList = iturs.Select(selectItur => String.Format("'{0}'", selectItur.IturId));
                var csIdList = String.Join(",", idList);
                return String.Format("IturId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Itur> iturs, string expandString)
        {
            
        }
        
    }
}