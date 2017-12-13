using MorseCodeSDK.Lib.SqlDataManagement;
using MorseCodeSDK.Lib.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;

namespace WebApplication1.Areas.RESTApi.Controllers
{
    public partial class ChannelsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Channel> Channels);
        partial void OnAfterGetById(Channel Channels, Guid channelId);
        partial void OnBeforePost(Channel channel);
        partial void OnAfterPost(Channel channel);
        partial void OnBeforePut(Channel channel);
        partial void OnAfterPut(Channel channel);
        partial void OnBeforeDelete(Channel channel);
        partial void OnAfterDelete(Channel channel);
        

        public ChannelsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Channel
        public IEnumerable<Channel> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllChannels<Channel>();
            Channel.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Channels/{channel-guid}
        public Channel Get(Guid channelId)
        {
            var ChannelsWhere = String.Format("ChannelId = '{0}'", channelId);
            var result = this.SDM.GetAllChannels<Channel>(ChannelsWhere).FirstOrDefault();
            this.OnAfterGetById(result, channelId);
            return result;
        }

        // POST api/Channels/{channel-guid}
        public Channel Post([FromBody]Channel channel)
        {
            if (channel.ChannelId == Guid.Empty) channel.ChannelId = Guid.NewGuid();
            this.OnBeforePost(channel);
            this.SDM.Upsert(channel);
            this.OnAfterPost(channel);
            return channel;
        }

        // POST api/Channels/{channel-guid}
        public Channel Put([FromBody]Channel channel)
        {
            if (channel.ChannelId == Guid.Empty) channel.ChannelId = Guid.NewGuid();
            this.OnBeforePut(channel);
            this.SDM.Upsert(channel);
            this.OnAfterPut(channel);
            return channel;
        }

        // POST api/Channels/{channel-guid}
        public void Delete(Guid channelId)
        {
            var channelWhere = String.Format("ChannelId = '{0}'", channelId);
            var channel = this.SDM.GetAllChannels<Channel>(channelWhere).FirstOrDefault();
            this.OnBeforeDelete(channel);
            this.SDM.Delete(channel);
            this.OnAfterDelete(channel);
        }
    }
}
