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
    public partial class BudgetsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Budget> Budgets);
        partial void OnAfterGetById(Budget Budgets, Guid budgetId);
        partial void OnBeforePost(Budget budget);
        partial void OnAfterPost(Budget budget);
        partial void OnBeforePut(Budget budget);
        partial void OnAfterPut(Budget budget);
        partial void OnBeforeDelete(Budget budget);
        partial void OnAfterDelete(Budget budget);
        

        public BudgetsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Budget
        public IEnumerable<Budget> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllBudgets<Budget>();
            Budget.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Budgets/{budget-guid}
        public Budget Get(Guid budgetId)
        {
            var BudgetsWhere = String.Format("BudgetId = '{0}'", budgetId);
            var result = this.SDM.GetAllBudgets<Budget>(BudgetsWhere).FirstOrDefault();
            this.OnAfterGetById(result, budgetId);
            return result;
        }

        // POST api/Budgets/{budget-guid}
        public Budget Post([FromBody]Budget budget)
        {
            if (budget.BudgetId == Guid.Empty) budget.BudgetId = Guid.NewGuid();
            this.OnBeforePost(budget);
            this.SDM.Upsert(budget);
            this.OnAfterPost(budget);
            return budget;
        }

        // POST api/Budgets/{budget-guid}
        public Budget Put([FromBody]Budget budget)
        {
            if (budget.BudgetId == Guid.Empty) budget.BudgetId = Guid.NewGuid();
            this.OnBeforePut(budget);
            this.SDM.Upsert(budget);
            this.OnAfterPut(budget);
            return budget;
        }

        // POST api/Budgets/{budget-guid}
        public void Delete(Guid budgetId)
        {
            var budgetWhere = String.Format("BudgetId = '{0}'", budgetId);
            var budget = this.SDM.GetAllBudgets<Budget>(budgetWhere).FirstOrDefault();
            this.OnBeforeDelete(budget);
            this.SDM.Delete(budget);
            this.OnAfterDelete(budget);
        }
    }
}
