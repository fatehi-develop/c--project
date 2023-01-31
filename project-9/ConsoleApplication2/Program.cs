using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//پروژه عمیات بین دو کسر
namespace ConsoleApplication2
{

    class calculate {
      private double num_s_1 , num_m_1 , num_s_2 , num_m_2 ; 

      public double set_num_s_1 {
        get{return num_s_1;}
        set{num_s_1 = value;}
      }

      public double set_num_m_1{
        get{return num_m_1;}
        set{num_m_1 = value;}
      }

      public double set_num_s_2{
        get{return num_m_2;}
        set{num_m_2 = value;}
      }

       public double set_num_m_2{
        get{return num_m_2;}
        set{num_m_2 = value;}
      }



       public void calcs() { }

       public bool calcs(double Num_s_1, double Num_m_1, double Num_s_2, double Num_m_2)
        { 
       num_s_1 = Num_s_1 ; 
       num_m_1 = Num_m_1 ; 
       num_s_2 = Num_s_2 ; 
       num_m_2 = Num_m_2 ;

       if (num_m_1 != 0 && num_m_2 != 0)
       {
            return true; 
       } else{
            Console.WriteLine("makhraj nemitavand zero bashed");
            return false; 
       }

      }


      public double sum(){
       double result = (num_s_1 / num_m_1) + (num_s_2 / num_m_2);
       return result ;
      }

      public double minus(){
       double result = (num_s_1 / num_m_1) - (num_s_2 / num_m_2);
       return result ;
      }

      public double zarb(){
       double result = (num_s_1 / num_m_1) * (num_s_2 / num_m_2);
       return result ;
      }

      public double tagsim(){
       double result = (num_s_1 / num_m_1) / (num_s_2 / num_m_2);
       return result ;
      }

    }

    class Program {
        static void Main(string[] args)
        {
           Console.WriteLine("sorat number 1 :");
           double num_s_1 = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("makhraj number 1 : ");
           double num_m_1 = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("sorat number 2 :");
           double num_s_2 = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("makhraj number 2 :");
           double num_m_2 = Convert.ToDouble(Console.ReadLine());

          calculate calculate_ob = new calculate();
          if (calculate_ob.calcs(num_s_1, num_m_1, num_s_2, num_m_2))
          {
            Console.WriteLine("sum : {0} " , calculate_ob.sum());
            Console.WriteLine("minus : {0} " , calculate_ob.minus());
            Console.WriteLine("zarb : {0} " , calculate_ob.zarb());
            Console.WriteLine("tagsim : {0} " , calculate_ob.tagsim());
          }
          Console.ReadKey();
        }
    }
}
