using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethodApp
{
    public static class StringExtension
    {
        public static string SnakeCase(this string str)
        {
            return str.Replace(' ', '_');
        }
    }
}
