using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Enwikipediaorgwikispecialcentralautologinstarttypex
    {
        private void InitPoco()
        {
            
            this.EnwikipediaorgwikispecialcentralautologinstarttypexId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "EnwikipediaorgwikispecialcentralautologinstarttypexId")]
        public Guid EnwikipediaorgwikispecialcentralautologinstarttypexId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateEnwikipediaorgwikispecialcentralautologinstarttypexWhere(IEnumerable<Enwikipediaorgwikispecialcentralautologinstarttypex> enwikipediaorgwikispecialcentralautologinstarttypexes)
        {
            if (!enwikipediaorgwikispecialcentralautologinstarttypexes.Any()) return "1=1";
            else 
            {
                var idList = enwikipediaorgwikispecialcentralautologinstarttypexes.Select(selectEnwikipediaorgwikispecialcentralautologinstarttypex => String.Format("'{0}'", selectEnwikipediaorgwikispecialcentralautologinstarttypex.EnwikipediaorgwikispecialcentralautologinstarttypexId));
                var csIdList = String.Join(",", idList);
                return String.Format("EnwikipediaorgwikispecialcentralautologinstarttypexId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Enwikipediaorgwikispecialcentralautologinstarttypex> enwikipediaorgwikispecialcentralautologinstarttypexes, string expandString)
        {
            
        }
        
    }
}