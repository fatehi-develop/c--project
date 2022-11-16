using System;

namespace project_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter inventory : "); 
            int inventory_n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter interest revenue : "); 
            int interest_revenue_n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the amount you want : "); 
            int get_amount_n = Convert.ToInt32(Console.ReadLine());

            if(get_amount_n > inventory_n){
                if(interest_revenue_n < 100 && interest_revenue_n > 0){
                    int annual_profit = ((inventory_n * interest_revenue_n) / 100) / 12;
                    double amount_interest_withdrawn = get_amount_n - inventory_n ;
                    double mounth = Math.Ceiling(amount_interest_withdrawn / annual_profit)  ;
                    Console.WriteLine("nearly {0} mounth" , mounth);
                } else{
                    Console.WriteLine("Bank interest must be greater than 0 and less than 100"); 
                }

            }else{
                    Console.WriteLine("The requested amount is less than the balance amount");
            }
        }
    }   
}
