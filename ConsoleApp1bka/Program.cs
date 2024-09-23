using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1bka
{
    class Program
    {
        static void Main(string[] args)
        {
        Double a = Convert.ToDouble(Console.ReadLine());
        Double b = Convert.ToDouble(Console.ReadLine());
          
            Console.WriteLine($" куб числа равен {grizld(a)}");
            Console.WriteLine($" квадрат числа равен {grizli2(a)}");
            Console.WriteLine($" сумма чисел равна {grizli3(a,b)}");
                  Console.ReadKey();
        }
        public static double grizld (double a)
            {
            
            
               return Math.Pow(a,3);
            }
          public static double grizli2 (double a)
            {
            
            
               return Math.Pow(a,2);
            }
         public static double grizli3 (double a, double b)
            {
            
            
               return a+b;





            }
      
    }

}
