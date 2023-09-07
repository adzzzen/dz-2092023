using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.найти знач косинуса с помощью math.cos
            int x =Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("cos{0}={1}",x,Math.Cos(x));
            Console.ReadLine();

        }
    }
}
