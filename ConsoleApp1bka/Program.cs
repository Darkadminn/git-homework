using System;
using System.Collections.Generic;
using System.Globalization;
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

            Console.WriteLine(ThreeNumber(8, 2, 2));
            Console.WriteLine(DayOfWeek(3));
            Console.WriteLine(Min(1, 5));
        }
        public static double ThreeNumber(int a, int b, int c)
        {
            return Convert.ToDouble((a - b)) / c;
        }
        public static string DayOfWeek(int a)
        {

            DateTime dateValue = new DateTime(1906, 1, a);
            string Name = dateValue.ToString("dddd");

            return Name;
        }
        public static int Min(int a, int b)
        {
            if (a < b) return a;

            return b;

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
