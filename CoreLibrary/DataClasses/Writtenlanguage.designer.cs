using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Writtenlanguage
    {
        private void InitPoco()
        {
            
            this.WrittenlanguageId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "WrittenlanguageId")]
        public Guid WrittenlanguageId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateWrittenlanguageWhere(IEnumerable<Writtenlanguage> writtenlanguages)
        {
            if (!writtenlanguages.Any()) return "1=1";
            else 
            {
                var idList = writtenlanguages.Select(selectWrittenlanguage => String.Format("'{0}'", selectWrittenlanguage.WrittenlanguageId));
                var csIdList = String.Join(",", idList);
                return String.Format("WrittenlanguageId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Writtenlanguage> writtenlanguages, string expandString)
        {
            
        }
        
    }
}