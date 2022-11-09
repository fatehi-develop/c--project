using System;

namespace project_3
{
    class Program
    {
        static void Main(string[] args)
        {
                String number = Console.ReadLine();
                int num = Convert.ToInt32(number);
                num = num + 10 ; 
                Console.WriteLine("num : {0}",  num); 
        }
    }
}
