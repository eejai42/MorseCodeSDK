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
    public partial class UsersController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<User> Users);
        partial void OnAfterGetById(User Users, Guid userId);
        partial void OnBeforePost(User user);
        partial void OnAfterPost(User user);
        partial void OnBeforePut(User user);
        partial void OnAfterPut(User user);
        partial void OnBeforeDelete(User user);
        partial void OnAfterDelete(User user);
        

        public UsersController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/User
        public IEnumerable<User> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllUsers<User>();
            User.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Users/{user-guid}
        public User Get(Guid userId)
        {
            var UsersWhere = String.Format("UserId = '{0}'", userId);
            var result = this.SDM.GetAllUsers<User>(UsersWhere).FirstOrDefault();
            this.OnAfterGetById(result, userId);
            return result;
        }

        // POST api/Users/{user-guid}
        public User Post([FromBody]User user)
        {
            if (user.UserId == Guid.Empty) user.UserId = Guid.NewGuid();
            this.OnBeforePost(user);
            this.SDM.Upsert(user);
            this.OnAfterPost(user);
            return user;
        }

        // POST api/Users/{user-guid}
        public User Put([FromBody]User user)
        {
            if (user.UserId == Guid.Empty) user.UserId = Guid.NewGuid();
            this.OnBeforePut(user);
            this.SDM.Upsert(user);
            this.OnAfterPut(user);
            return user;
        }

        // POST api/Users/{user-guid}
        public void Delete(Guid userId)
        {
            var userWhere = String.Format("UserId = '{0}'", userId);
            var user = this.SDM.GetAllUsers<User>(userWhere).FirstOrDefault();
            this.OnBeforeDelete(user);
            this.SDM.Delete(user);
            this.OnAfterDelete(user);
        }
    }
}
