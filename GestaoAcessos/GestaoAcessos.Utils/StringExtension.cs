using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class StringExtension
    {

        public static bool IsNullOrEmpty(this string pString)
        {
            return string.IsNullOrEmpty(pString);
        }
         
    }
}
