using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Knowledge
    {
        private void InitPoco()
        {
            
            this.KnowledgeId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "KnowledgeId")]
        public Guid KnowledgeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateKnowledgeWhere(IEnumerable<Knowledge> knowledges)
        {
            if (!knowledges.Any()) return "1=1";
            else 
            {
                var idList = knowledges.Select(selectKnowledge => String.Format("'{0}'", selectKnowledge.KnowledgeId));
                var csIdList = String.Join(",", idList);
                return String.Format("KnowledgeId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Knowledge> knowledges, string expandString)
        {
            
        }
        
    }
}