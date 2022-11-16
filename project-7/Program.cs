using System;

namespace project_7
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("enter number days : "); 
          string get_days = Console.ReadLine();
          int number_valid = 0;
          if(int.TryParse(get_days, out number_valid)){
                int days = Convert.ToInt32(get_days);
                int year = days / 365 ;

                int mounth = 0;
                int mounth_days_main = (days  - (year * 365));
                int mounth_days = (days  - (year * 365));
                int day_c = 0;

                if(mounth_days <= 186){

                    mounth_days = (days  - (year * 365)) ;
                    mounth = mounth_days / 31 ;
                    day_c = (mounth_days_main - (mounth * 31));

                }else if(mounth_days <= 336){
                    mounth_days = (mounth_days - ( 6 * 31 )) ;
                    mounth = 6 + (mounth_days / 30) ;
                    day_c = mounth_days_main - ( 6 * 31 ) - (mounth_days);
                }else{
                     mounth = 11;
                     day_c = mounth_days_main - ( 6 * 31 ) - (5 * 30);

                }                
                Console.WriteLine("{0} year  {1} mounth  {2} day" , year , mounth , day_c ); 
          } else{
            Console.WriteLine("not valid number"); 
          }
        }
    }
}
