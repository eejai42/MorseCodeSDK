/*************************************************
Initially Generated by SSoT.me - 2017
    EJ Alexandra - An odxml42 Tool
    This file will not be overwritten by default!
*************************************************/
using System;
using System.ComponentModel;
                        
namespace MorseCodeSDK.Lib.DataClasses
{                   
    
    public partial class Distress 
    {
        public Distress()
        {
            this.InitPoco();
        }

        public override String ToString()
        {
            return String.Format("Distress: {0}", this.Name);
        }
    }
}