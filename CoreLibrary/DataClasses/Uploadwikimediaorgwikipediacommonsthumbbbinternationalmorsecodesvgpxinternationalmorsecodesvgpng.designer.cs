using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng
    {
        private void InitPoco()
        {
            
            this.UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId")]
        public Guid UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateUploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngWhere(IEnumerable<Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng> uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngs)
        {
            if (!uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngs.Any()) return "1=1";
            else 
            {
                var idList = uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngs.Select(selectUploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng => String.Format("'{0}'", selectUploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng.UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId));
                var csIdList = String.Join(",", idList);
                return String.Format("UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng> uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngs, string expandString)
        {
            
        }
        
    }
}