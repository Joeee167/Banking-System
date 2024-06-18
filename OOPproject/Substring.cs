using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    public static class StringExtensions
    {
        public static string[] SplitBySubstring(this string input, string s)
        {
            return input.Split(new string[] { s }, StringSplitOptions.None);
        }
    }
}
