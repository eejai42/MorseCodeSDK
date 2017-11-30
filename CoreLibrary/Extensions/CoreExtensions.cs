using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.Extensions
{
    public static class CoreExtensions
    {
        public static String SafeToString(this object obj)
        {
            if (ReferenceEquals(obj, null)) return String.Empty;
            else return obj.ToString();
        }
    }
}
