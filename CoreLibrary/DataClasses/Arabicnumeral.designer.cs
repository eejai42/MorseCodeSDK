using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Arabicnumeral
    {
        private void InitPoco()
        {
            
            this.ArabicnumeralId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ArabicnumeralId")]
        public Guid ArabicnumeralId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateArabicnumeralWhere(IEnumerable<Arabicnumeral> arabicnumerals)
        {
            if (!arabicnumerals.Any()) return "1=1";
            else 
            {
                var idList = arabicnumerals.Select(selectArabicnumeral => String.Format("'{0}'", selectArabicnumeral.ArabicnumeralId));
                var csIdList = String.Join(",", idList);
                return String.Format("ArabicnumeralId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Arabicnumeral> arabicnumerals, string expandString)
        {
            
        }
        
    }
}