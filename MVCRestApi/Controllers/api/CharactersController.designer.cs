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
    public partial class CharactersController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Character> Characters);
        partial void OnAfterGetById(Character Characters, Guid characterId);
        partial void OnBeforePost(Character character);
        partial void OnAfterPost(Character character);
        partial void OnBeforePut(Character character);
        partial void OnAfterPut(Character character);
        partial void OnBeforeDelete(Character character);
        partial void OnAfterDelete(Character character);
        

        public CharactersController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Character
        public IEnumerable<Character> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllCharacters<Character>();
            Character.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Characters/{character-guid}
        public Character Get(Guid characterId)
        {
            var CharactersWhere = String.Format("CharacterId = '{0}'", characterId);
            var result = this.SDM.GetAllCharacters<Character>(CharactersWhere).FirstOrDefault();
            this.OnAfterGetById(result, characterId);
            return result;
        }

        // POST api/Characters/{character-guid}
        public Character Post([FromBody]Character character)
        {
            if (character.CharacterId == Guid.Empty) character.CharacterId = Guid.NewGuid();
            this.OnBeforePost(character);
            this.SDM.Upsert(character);
            this.OnAfterPost(character);
            return character;
        }

        // POST api/Characters/{character-guid}
        public Character Put([FromBody]Character character)
        {
            if (character.CharacterId == Guid.Empty) character.CharacterId = Guid.NewGuid();
            this.OnBeforePut(character);
            this.SDM.Upsert(character);
            this.OnAfterPut(character);
            return character;
        }

        // POST api/Characters/{character-guid}
        public void Delete(Guid characterId)
        {
            var characterWhere = String.Format("CharacterId = '{0}'", characterId);
            var character = this.SDM.GetAllCharacters<Character>(characterWhere).FirstOrDefault();
            this.OnBeforeDelete(character);
            this.SDM.Delete(character);
            this.OnAfterDelete(character);
        }
    }
}
