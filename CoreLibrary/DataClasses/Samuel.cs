/*************************************************
Initially Generated by SSoT.me - 2017
    EJ Alexandra - An odxml42 Tool
    This file will not be overwritten by default!
*************************************************/
using System;
using System.ComponentModel;
                        
namespace MorseCodeSDK.Lib.DataClasses
{                   
    
    public partial class Samuel 
    {
        public Samuel()
        {
            this.InitPoco();
        }

        public override String ToString()
        {
            return String.Format("Samuel: {0}", this.Name);
        }
    }
}