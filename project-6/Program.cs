using System;
using System.Linq;

namespace project_6
{
    class Program
    {
        public static void Main(string[] args)
        {
          Console.WriteLine("enter number"); 
          string x = Console.ReadLine();
          int number_valid = 0;
          if(int.TryParse(x, out number_valid)){
                int a = Convert.ToInt32(x);
                double Power_2 = Power_two(a);
                Console.WriteLine("number Power_two : {0}" , Power_2); 
          }else{
            Console.WriteLine("not valid number"); 
          }
        }

        public static double Power_two(int x) 
        {
            double Power = Math.Pow(x , 2);
            return Power ;
        }
    }
}
