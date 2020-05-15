using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            WriteLine("Введите номер задания");
            N=ToInt32(ReadLine());
            if (N == 1)
            {
                string a = "",b="";
                WriteLine("введите строку");
                a = ReadLine();
                WriteLine("ввелите какую букву хотите найти");
                string f = ReadLine();
                if (a.IndexOf(f) == -1)
                {
                    WriteLine("-2");
                }
                else if (a.IndexOf(f) != -1)
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (i != a.IndexOf(f))
                        {
                            b = b + a[i];
                        }
                    }

                    if (b.IndexOf(f) == -1)
                    {
                        WriteLine("-1");
                    }
                    else
                    {
                        WriteLine(b.IndexOf(f) + 2);
                    }
                }
            }
            else if (N == 2)
            {

                WriteLine("введите строку");
                string a = ReadLine();
                string b = "";
                string[] r = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };
                string[] e = { "A", "B", "V", "G", "D", "E", "E", "ZH", "Z", "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F", "KH", "TS", "CH", "SH", "SHCH", "", "Y", "", "E", "YU", "YA" };
                a = a.ToUpper();
                for (int i = 0; i < a.Length; i++)
                {
                    int j = 0;
                    while (j < r.Length)
                    {

                        string x = a[i] + "";
                        if (x == r[j])
                        {
                            b = b + e[j];
                        }
                        j++;
                    }
                }
                WriteLine(b);
            }
            else if (N == 3)
            {
                string a = "", b = "",rez="";
                int f = 0, l = 0;
                WriteLine("введите строку");
                a = ReadLine();
                f = a.IndexOf("h");
                l = a.LastIndexOf("h");
                for (int i = 0; i < a.Length; i++)
                {

                    if (i==f||i==l)
                    {
                        
                    }
                    else
                    {
                        b = b + a[i];
                    }
                }
                b = b.Replace("h", "H");
                for (int i = 0; i < b.Length; i++)
                {
                    if (i == f || i == l)
                    {
                        rez = rez + "h" + b[i];
                    }
                    else
                    {
                        rez = rez + b[i];
                    }
                    
                }
                if (l == a.Length - 1)
                {
                    rez = rez + "h";
                }
                WriteLine(rez);
            }
            ReadLine();
        }
        
    }
}
