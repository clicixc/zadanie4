using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using static System.Convert;
using static System.Console;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList c = new ArrayList();
            ArrayList c1 = new ArrayList();
            c.Add(2);
            c.Add(-5);
            c.Add("!");
            c.Add("#");
            c.Add(10);
            c.Add("gf");
            c.Add(92);
            c.Add("(");
            c.Add(-6);
            c.Add(")");
            c.Add(12);
            c.Add("?");
            c.Add(-72);
            c.Add("%");
            c.Add(43);
            for (int i = 0; i < c.Count; i++)
            {
                Write(c[i]+"  ");
               
            }
            WriteLine();
            for (int i = 0; i < c.Count; i++)
            {
                try
                {
                    int a = ToInt32(c[i]);                   
                }
                catch (Exception)
                {
                    c1.Add(c[i]);
                    c.RemoveAt(i);
                    i--;
                } 
            }
            for (int i = 0; i < c.Count; i++)
            {
                Write(c[i] + "  ");

            }
            WriteLine();
            for (int i = 0; i < c1.Count; i++)
            {
                Write(c1[i] + "  ");

            }
            ReadLine();
        }
    }
}
