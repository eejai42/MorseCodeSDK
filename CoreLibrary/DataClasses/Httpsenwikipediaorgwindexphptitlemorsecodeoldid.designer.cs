using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Httpsenwikipediaorgwindexphptitlemorsecodeoldid
    {
        private void InitPoco()
        {
            
            this.HttpsenwikipediaorgwindexphptitlemorsecodeoldidId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "HttpsenwikipediaorgwindexphptitlemorsecodeoldidId")]
        public Guid HttpsenwikipediaorgwindexphptitlemorsecodeoldidId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateHttpsenwikipediaorgwindexphptitlemorsecodeoldidWhere(IEnumerable<Httpsenwikipediaorgwindexphptitlemorsecodeoldid> httpsenwikipediaorgwindexphptitlemorsecodeoldids)
        {
            if (!httpsenwikipediaorgwindexphptitlemorsecodeoldids.Any()) return "1=1";
            else 
            {
                var idList = httpsenwikipediaorgwindexphptitlemorsecodeoldids.Select(selectHttpsenwikipediaorgwindexphptitlemorsecodeoldid => String.Format("'{0}'", selectHttpsenwikipediaorgwindexphptitlemorsecodeoldid.HttpsenwikipediaorgwindexphptitlemorsecodeoldidId));
                var csIdList = String.Join(",", idList);
                return String.Format("HttpsenwikipediaorgwindexphptitlemorsecodeoldidId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Httpsenwikipediaorgwindexphptitlemorsecodeoldid> httpsenwikipediaorgwindexphptitlemorsecodeoldids, string expandString)
        {
            
        }
        
    }
}