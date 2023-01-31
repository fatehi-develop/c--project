using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//فاصل دو نقطه از هم روی محور 
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter x1 : ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter y1 : ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter x2 : ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter y2 : ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            claculate_point claculate = new claculate_point(x1, x2, y1, y2);
            Console.WriteLine("result :  {0}", claculate.clac_formla());
            Console.ReadKey();



        }
    }

    class claculate_point {
        private double X1 , X2 , Y1 , Y2 ;

        public double set_X1{
            get{return X1;}
            set{X1 = value;}
        }
        public double set_X2{
            get {return X2;}
            set {X2 = value;}
        }
        public double set_Y1 {
            get{return Y1;}
            set{Y1 = value;}
        }
        public double set_Y2{
            get{return Y2;}
            set{Y2 = value;}
        }

        public claculate_point(){}

        public claculate_point(double x1, double x2, double y1, double y2)
        {
            X1 = x1 ;
            
            X2 = x2 ; 
            
            Y1 = y1 ; 
            
            Y2 = y2 ;
        }

        public double clac_formla(){
           double result = Math.Sqrt(Math.Pow(( X2 - X1 ) , 2) + Math.Pow(( Y2 - Y1 ) , 2));
           return result; 
        }
    }
}
