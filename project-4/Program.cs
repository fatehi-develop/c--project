using System;

namespace project_4
{
    class Program
    {
        static void Main(string[] args)
        {
          string number_1 = Console.ReadLine();
          string number_2 = Console.ReadLine();
          int x = Convert.ToInt32(number_1);
          int y = Convert.ToInt32(number_2);
          double  num_1 = Math.Abs( x - y );
          double  num_2 = Math.Pow(num_1 , Math.Abs(y));
          double  num_3 = Math.Sqrt(num_2);
          Console.WriteLine("result : {0}",  num_3); 
        }
    }
}
