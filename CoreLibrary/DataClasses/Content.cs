/*************************************************
Initially Generated by SSoT.me - 2017
    EJ Alexandra - An odxml42 Tool
    This file will not be overwritten by default!
*************************************************/
using System;
using System.ComponentModel;
                        
namespace MorseCodeSDK.Lib.DataClasses
{                   
    
    public partial class Content 
    {
        public Content()
        {
            this.InitPoco();
        }

        public override String ToString()
        {
            return String.Format("Content: {0}", this.Name);
        }
    }
}