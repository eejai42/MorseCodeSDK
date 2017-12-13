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
    public partial class SpacesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Space> Spaces);
        partial void OnAfterGetById(Space Spaces, Guid spaceId);
        partial void OnBeforePost(Space space);
        partial void OnAfterPost(Space space);
        partial void OnBeforePut(Space space);
        partial void OnAfterPut(Space space);
        partial void OnBeforeDelete(Space space);
        partial void OnAfterDelete(Space space);
        

        public SpacesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Space
        public IEnumerable<Space> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllSpaces<Space>();
            Space.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Spaces/{space-guid}
        public Space Get(Guid spaceId)
        {
            var SpacesWhere = String.Format("SpaceId = '{0}'", spaceId);
            var result = this.SDM.GetAllSpaces<Space>(SpacesWhere).FirstOrDefault();
            this.OnAfterGetById(result, spaceId);
            return result;
        }

        // POST api/Spaces/{space-guid}
        public Space Post([FromBody]Space space)
        {
            if (space.SpaceId == Guid.Empty) space.SpaceId = Guid.NewGuid();
            this.OnBeforePost(space);
            this.SDM.Upsert(space);
            this.OnAfterPost(space);
            return space;
        }

        // POST api/Spaces/{space-guid}
        public Space Put([FromBody]Space space)
        {
            if (space.SpaceId == Guid.Empty) space.SpaceId = Guid.NewGuid();
            this.OnBeforePut(space);
            this.SDM.Upsert(space);
            this.OnAfterPut(space);
            return space;
        }

        // POST api/Spaces/{space-guid}
        public void Delete(Guid spaceId)
        {
            var spaceWhere = String.Format("SpaceId = '{0}'", spaceId);
            var space = this.SDM.GetAllSpaces<Space>(spaceWhere).FirstOrDefault();
            this.OnBeforeDelete(space);
            this.SDM.Delete(space);
            this.OnAfterDelete(space);
        }
    }
}
