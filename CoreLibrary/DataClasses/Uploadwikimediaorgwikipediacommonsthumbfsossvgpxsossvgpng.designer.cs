using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng
    {
        private void InitPoco()
        {
            
            this.UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId")]
        public Guid UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateUploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngWhere(IEnumerable<Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng> uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngs)
        {
            if (!uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngs.Any()) return "1=1";
            else 
            {
                var idList = uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngs.Select(selectUploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng => String.Format("'{0}'", selectUploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng.UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId));
                var csIdList = String.Join(",", idList);
                return String.Format("UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng> uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngs, string expandString)
        {
            
        }
        
    }
}