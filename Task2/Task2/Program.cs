using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a; int b; int c; int d; 
            Console.WriteLine("Введите а");
           
            a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите b");
            b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите c");
            c = int.Parse(Console.ReadLine());
            
            Console.WriteLine("{0}*x^2 + {1}*x + {2} = 0", a, b, c);

            d = b*b - 4*a*c;
            Console.WriteLine("d = {1}^2 - 4*{0}*{2} = {3}",a ,b ,c, d);
            if (d < 0)
            {
                Console.WriteLine("d < 0, Корней нет");
            }
            else if (d == 0)
            {
                Console.WriteLine("d = 0, Один корень");
                double x1 = -b / (2 * a);
                Console.WriteLine("x = -{1} / 2*{0} = {3}", a, b, d, x1);
            }
            else
            {
                Console.WriteLine("d > 0, Два кореня");
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1 = (-{1} + {2})/ 2*{0} = {3}", a, b, d, x1);
                Console.WriteLine("x2 = (-{1} - {2})/ 2*{0} = {3}", a, b, d, x2);
            }

            Console.ReadKey();
            //ax^2 + bx + c = 0
                //d = b*b-4ac








            /*
            int WeightByStr = 20;


            Console.Write("Введите силу персонажа: ");
            string strStr = Console.ReadLine();
            int str = int.Parse(strStr);


            Console.Write("Введите вес вещей: ");
            String strWeight = Console.ReadLine();
            int Weight = int.Parse(strWeight);

            if (Weight > str * WeightByStr)
            {
                Console.WriteLine("Скорость передвижения: < 100%");
            }
            else if (Weight < str * WeightByStr / 2)
            {
                Console.WriteLine("Скорость персонажа: 150%");
            }
            else
            {
                Console.WriteLine("Скорость передвижения: 100%");
            }
                
            Console.ReadKey();
             */
        }
    }
}
