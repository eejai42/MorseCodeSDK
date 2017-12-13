using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Issue
    {
        private void InitPoco()
        {
            
            this.IssueId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IssueId")]
        public Guid IssueId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateIssueWhere(IEnumerable<Issue> issues)
        {
            if (!issues.Any()) return "1=1";
            else 
            {
                var idList = issues.Select(selectIssue => String.Format("'{0}'", selectIssue.IssueId));
                var csIdList = String.Join(",", idList);
                return String.Format("IssueId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Issue> issues, string expandString)
        {
            
        }
        
    }
}