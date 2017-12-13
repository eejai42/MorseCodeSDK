using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Bibliography
    {
        private void InitPoco()
        {
            
            this.BibliographyId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BibliographyId")]
        public Guid BibliographyId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateBibliographyWhere(IEnumerable<Bibliography> bibliographies)
        {
            if (!bibliographies.Any()) return "1=1";
            else 
            {
                var idList = bibliographies.Select(selectBibliography => String.Format("'{0}'", selectBibliography.BibliographyId));
                var csIdList = String.Join(",", idList);
                return String.Format("BibliographyId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Bibliography> bibliographies, string expandString)
        {
            
        }
        
    }
}