using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.найти площадь и длину круга.расписать формулы применяя math.pi
            double radius, area, length;
            Console.WriteLine("введите радиус");
            radius = Convert.ToDouble(Console.ReadLine());
            length = Math.PI * 2 * radius;
            area = Math.PI * radius * radius;
            Console.WriteLine("радиус круга равен {0}, площадь {1}, длина {2}", radius, length, area);
            Console.ReadKey();


            
        }
    }
}
