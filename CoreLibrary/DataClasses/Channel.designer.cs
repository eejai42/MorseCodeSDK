using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Channel
    {
        private void InitPoco()
        {
            
            this.ChannelId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ChannelId")]
        public Guid ChannelId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateChannelWhere(IEnumerable<Channel> channels)
        {
            if (!channels.Any()) return "1=1";
            else 
            {
                var idList = channels.Select(selectChannel => String.Format("'{0}'", selectChannel.ChannelId));
                var csIdList = String.Join(",", idList);
                return String.Format("ChannelId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Channel> channels, string expandString)
        {
            
        }
        
    }
}