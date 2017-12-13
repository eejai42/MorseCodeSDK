using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Mnemonic
    {
        private void InitPoco()
        {
            
            this.MnemonicId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MnemonicId")]
        public Guid MnemonicId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateMnemonicWhere(IEnumerable<Mnemonic> mnemonics)
        {
            if (!mnemonics.Any()) return "1=1";
            else 
            {
                var idList = mnemonics.Select(selectMnemonic => String.Format("'{0}'", selectMnemonic.MnemonicId));
                var csIdList = String.Join(",", idList);
                return String.Format("MnemonicId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Mnemonic> mnemonics, string expandString)
        {
            
        }
        
    }
}