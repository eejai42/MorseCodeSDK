using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Budget
    {
        private void InitPoco()
        {
            
            this.BudgetId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "BudgetId")]
        public Guid BudgetId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateBudgetWhere(IEnumerable<Budget> budgets)
        {
            if (!budgets.Any()) return "1=1";
            else 
            {
                var idList = budgets.Select(selectBudget => String.Format("'{0}'", selectBudget.BudgetId));
                var csIdList = String.Join(",", idList);
                return String.Format("BudgetId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Budget> budgets, string expandString)
        {
            
        }
        
    }
}