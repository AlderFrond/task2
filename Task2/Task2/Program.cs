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
            int WeightByStr = 20;


            Console.Write("Введите силу персонажа: ");
            string strStr = Console.ReadLine();
            int str = int.Parse(strStr);

            
            Console.Write("Введите вес вещей: ");
            String strWeight = Console.ReadLine();
            int Weight = int.Parse(strWeight);

            if (Weight > str * WeightByStr)
            {
                Console.WriteLine("перегруз");
            }
            else
            {
                Console.WriteLine("норма");
            }
            Console.ReadKey();
        }
    }
}
