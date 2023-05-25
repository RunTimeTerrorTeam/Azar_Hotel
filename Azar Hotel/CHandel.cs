using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Azar_Hotel
{
    class CHandel
    {
        public static bool isString(string str) { return Regex.IsMatch(str, "^[A-Z\\d a-z]+$"); }
        public static bool isEmail(string str) { return Regex.IsMatch(str, "^([A-Za-z]+\\d*)+\\w*@[A-Za-z]+\\.[A-Za-z]+$"); }
        public static bool isUsername(string str) { return Regex.IsMatch(str, "^(\\w+\\d*)+$"); }
        public static bool isPhone(string str) { return Regex.IsMatch(str, "^\\+?\\(?\\d+\\)?\\d+$"); }
        public static bool isInteger(string str) { return Regex.IsMatch(str, "^\\d+$"); }
        public static bool isDouble(string str) { return Regex.IsMatch(str, "^(\\d+\\.)?\\d+$"); }
        public static string Msg(string msg)
        {
            msg = Regex.Match(msg, "~.+~").Value;
            return msg.Substring(1, msg.Length - 2);
        }
    }
}
