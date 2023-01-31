using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Name : ");
            String get_Name = Console.ReadLine();
            Console.WriteLine("enter Id : ");
            String get_Id = Console.ReadLine();
            Console.WriteLine("enter Date_rejester : ");
            String get_Date_rejester = Console.ReadLine();
            Console.WriteLine("enter Mony : ");
            double get_Mony = Convert.ToDouble(Console.ReadLine());

            karmand karmand_set = new karmand(get_Name, get_Id, get_Date_rejester, get_Mony);
            Console.WriteLine(karmand_set.haghog_daryafti());
            Console.ReadKey();
        }
    }
    class karmand {
        private String Name;
        private String Id;
        private String Date_rejester;
        private double Mony;


        public string set_id {
            get { return Id;  }
            set { Id = value; }
        }
        public string set_name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string set_date_rejester
        {
            get { return Date_rejester; }
            set { Date_rejester = value; }
        }
        public double set_mony
        {
            get { return Mony; }
            set { Mony = value; }
        }

        public karmand() { }
        public karmand(string get_Name, string get_Id, string get_Date_rejester, double get_Mony)
        {
              Name = get_Name ; 
              Id = get_Id ;
              Date_rejester = get_Date_rejester ; 
              Mony = get_Mony ;
        }

        public double calc_bime (){
          double bime = (Mony * 7 ) / 100 ; 
          return bime;
        }

        public double clac_maliat (){
          if(Mony > 6500000 ) {
            return Mony * 10 / 100 ; 
          }else{
            return 0 ;
          }
        }
        public double haghog_daryafti(){
          double mony_end = Mony - calc_bime() - clac_maliat() ;
          return mony_end; 
        }

    }
}
