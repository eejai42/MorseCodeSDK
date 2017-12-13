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
    public partial class SymbolsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Symbol> Symbols);
        partial void OnAfterGetById(Symbol Symbols, Guid symbolId);
        partial void OnBeforePost(Symbol symbol);
        partial void OnAfterPost(Symbol symbol);
        partial void OnBeforePut(Symbol symbol);
        partial void OnAfterPut(Symbol symbol);
        partial void OnBeforeDelete(Symbol symbol);
        partial void OnAfterDelete(Symbol symbol);
        

        public SymbolsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Symbol
        public IEnumerable<Symbol> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllSymbols<Symbol>();
            Symbol.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Symbols/{symbol-guid}
        public Symbol Get(Guid symbolId)
        {
            var SymbolsWhere = String.Format("SymbolId = '{0}'", symbolId);
            var result = this.SDM.GetAllSymbols<Symbol>(SymbolsWhere).FirstOrDefault();
            this.OnAfterGetById(result, symbolId);
            return result;
        }

        // POST api/Symbols/{symbol-guid}
        public Symbol Post([FromBody]Symbol symbol)
        {
            if (symbol.SymbolId == Guid.Empty) symbol.SymbolId = Guid.NewGuid();
            this.OnBeforePost(symbol);
            this.SDM.Upsert(symbol);
            this.OnAfterPost(symbol);
            return symbol;
        }

        // POST api/Symbols/{symbol-guid}
        public Symbol Put([FromBody]Symbol symbol)
        {
            if (symbol.SymbolId == Guid.Empty) symbol.SymbolId = Guid.NewGuid();
            this.OnBeforePut(symbol);
            this.SDM.Upsert(symbol);
            this.OnAfterPut(symbol);
            return symbol;
        }

        // POST api/Symbols/{symbol-guid}
        public void Delete(Guid symbolId)
        {
            var symbolWhere = String.Format("SymbolId = '{0}'", symbolId);
            var symbol = this.SDM.GetAllSymbols<Symbol>(symbolWhere).FirstOrDefault();
            this.OnBeforeDelete(symbol);
            this.SDM.Delete(symbol);
            this.OnAfterDelete(symbol);
        }
    }
}
