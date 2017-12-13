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
    public partial class MnemonicsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Mnemonic> Mnemonics);
        partial void OnAfterGetById(Mnemonic Mnemonics, Guid mnemonicId);
        partial void OnBeforePost(Mnemonic mnemonic);
        partial void OnAfterPost(Mnemonic mnemonic);
        partial void OnBeforePut(Mnemonic mnemonic);
        partial void OnAfterPut(Mnemonic mnemonic);
        partial void OnBeforeDelete(Mnemonic mnemonic);
        partial void OnAfterDelete(Mnemonic mnemonic);
        

        public MnemonicsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Mnemonic
        public IEnumerable<Mnemonic> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllMnemonics<Mnemonic>();
            Mnemonic.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Mnemonics/{mnemonic-guid}
        public Mnemonic Get(Guid mnemonicId)
        {
            var MnemonicsWhere = String.Format("MnemonicId = '{0}'", mnemonicId);
            var result = this.SDM.GetAllMnemonics<Mnemonic>(MnemonicsWhere).FirstOrDefault();
            this.OnAfterGetById(result, mnemonicId);
            return result;
        }

        // POST api/Mnemonics/{mnemonic-guid}
        public Mnemonic Post([FromBody]Mnemonic mnemonic)
        {
            if (mnemonic.MnemonicId == Guid.Empty) mnemonic.MnemonicId = Guid.NewGuid();
            this.OnBeforePost(mnemonic);
            this.SDM.Upsert(mnemonic);
            this.OnAfterPost(mnemonic);
            return mnemonic;
        }

        // POST api/Mnemonics/{mnemonic-guid}
        public Mnemonic Put([FromBody]Mnemonic mnemonic)
        {
            if (mnemonic.MnemonicId == Guid.Empty) mnemonic.MnemonicId = Guid.NewGuid();
            this.OnBeforePut(mnemonic);
            this.SDM.Upsert(mnemonic);
            this.OnAfterPut(mnemonic);
            return mnemonic;
        }

        // POST api/Mnemonics/{mnemonic-guid}
        public void Delete(Guid mnemonicId)
        {
            var mnemonicWhere = String.Format("MnemonicId = '{0}'", mnemonicId);
            var mnemonic = this.SDM.GetAllMnemonics<Mnemonic>(mnemonicWhere).FirstOrDefault();
            this.OnBeforeDelete(mnemonic);
            this.SDM.Delete(mnemonic);
            this.OnAfterDelete(mnemonic);
        }
    }
}
