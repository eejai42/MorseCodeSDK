using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Sequence
    {
        private void InitPoco()
        {
            
            this.SequenceId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SequenceId")]
        public Guid SequenceId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateSequenceWhere(IEnumerable<Sequence> sequences)
        {
            if (!sequences.Any()) return "1=1";
            else 
            {
                var idList = sequences.Select(selectSequence => String.Format("'{0}'", selectSequence.SequenceId));
                var csIdList = String.Join(",", idList);
                return String.Format("SequenceId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Sequence> sequences, string expandString)
        {
            
        }
        
    }
}