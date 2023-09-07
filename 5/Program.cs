using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7.c пом. модуля рандома вывести 4 числа
            Random rnd = new Random();  
            int a = rnd.Next();
            int b = rnd.Next();
            int c = rnd.Next();
            int d = rnd.Next();

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
