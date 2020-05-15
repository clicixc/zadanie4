using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;
using static System.String;


namespace zadanie1
{
    public class Class1
    {
        public static string stpow(string a, int b)
        {
            string c = "";
            for (int i = 0; i < b; i++)
            {
                c = c + a;
            }
            return c;
        }
        public static string rev(string a)
        {
            string c = "", b = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                b = a[i] + "";
                c = c + b;
            }
            return c;
        }
        public static string remov(string str, string s)
        {
            string c = "";
            c = str.Replace(s, "");
            return c;
        }
        public static int leng(string str)
        {
            return str.Length;
        }
    }
}
