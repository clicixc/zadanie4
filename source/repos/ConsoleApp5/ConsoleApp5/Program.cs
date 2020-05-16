using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;
using static System.Math;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            WriteLine("введите номер задания");
            int N = ToInt32(ReadLine());
            if (N==1)
            {
                WriteLine("введите размер массива");
                int j = ToInt32(ReadLine()),min=0,n=0;
                int[] a = new int[j];
                for (int i = 0; i < j; i++)
                {
                    
                    a[i] = r.Next(-40, 40);
                    Write(a[i] + "  ");
                    if (i == 0)
                    {
                        min = Abs(a[i]);
                        
                    }
                    if (min>Abs(a[i]))
                    {
                        min = Abs(a[i]);
                        n = i;
                    }
                }
                WriteLine("номер элемента "+n+1);
                
            }
            else if (N==2)
            {
                WriteLine("введите размер массива");
                int j = ToInt32(ReadLine()),n = 0;
                int[] a = new int[j];
                for (int i = 0; i < j; i++)
                {

                    a[i] = r.Next(-20, 20);
                    Write(a[i] + "  ");
                }
                WriteLine();
                for (int i = 0; i <j; i++)
                {
                    int u = 0;
                    for (int q = 0; q <j;q++)
                    {
                        if (a[i]==a[q])
                        {
                            u++;
                        }
                    }
                    if (u==1)
                    {
                        Write(a[i] + " ");
                    }
                }
            }
            else if (N==3)
            {
                WriteLine("введите размер массива");
                int j = ToInt32(ReadLine()), n = 0;
                int[] a = new int[j];
                for (int i = 0; i < j; i++)
                {

                    a[i] = r.Next(-20, 20);
                    Write(a[i] + "  ");
                }
                WriteLine();
                for (int i = 0; i < j; i++)
                {
                    if (a[i]>=0)
                    {
                        Write(a[i] + "  ");
                    }
                }
            }
            ReadLine();
        }
    }
}
