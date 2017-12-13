using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Fileinternationalmorsecodesvg
    {
        private void InitPoco()
        {
            
            this.FileinternationalmorsecodesvgId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FileinternationalmorsecodesvgId")]
        public Guid FileinternationalmorsecodesvgId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateFileinternationalmorsecodesvgWhere(IEnumerable<Fileinternationalmorsecodesvg> fileinternationalmorsecodesvgs)
        {
            if (!fileinternationalmorsecodesvgs.Any()) return "1=1";
            else 
            {
                var idList = fileinternationalmorsecodesvgs.Select(selectFileinternationalmorsecodesvg => String.Format("'{0}'", selectFileinternationalmorsecodesvg.FileinternationalmorsecodesvgId));
                var csIdList = String.Join(",", idList);
                return String.Format("FileinternationalmorsecodesvgId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Fileinternationalmorsecodesvg> fileinternationalmorsecodesvgs, string expandString)
        {
            
        }
        
    }
}