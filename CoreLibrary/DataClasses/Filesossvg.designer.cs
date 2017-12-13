using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Filesossvg
    {
        private void InitPoco()
        {
            
            this.FilesossvgId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FilesossvgId")]
        public Guid FilesossvgId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateFilesossvgWhere(IEnumerable<Filesossvg> filesossvgs)
        {
            if (!filesossvgs.Any()) return "1=1";
            else 
            {
                var idList = filesossvgs.Select(selectFilesossvg => String.Format("'{0}'", selectFilesossvg.FilesossvgId));
                var csIdList = String.Join(",", idList);
                return String.Format("FilesossvgId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Filesossvg> filesossvgs, string expandString)
        {
            
        }
        
    }
}