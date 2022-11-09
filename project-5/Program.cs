using System;

namespace project_5
{
    class Program
    {
        public static void Main(string[] args)
        {
          Console.WriteLine("enter number 1"); 
          string x = Console.ReadLine();
          Console.WriteLine("enter number 2"); 
          string y = Console.ReadLine();
          Console.WriteLine("enter number 3"); 
          string z = Console.ReadLine();
          int a = Convert.ToInt32(x);
          int b = Convert.ToInt32(y);
          int c = Convert.ToInt32(z);

          if(a + b > c && a + c > b && b + c > a){
            Mohit(a , b , c);
          }
        }

        public static void Mohit(int x , int y , int z) 
        {
            int  Mohit = x + y + z ;
            Console.WriteLine("Mohit : {0}" , Mohit);
        }
    }
}
