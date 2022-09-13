using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Admin
{
    public class customer
    {
        public  List<Class1> ad = new List<Class1>();
        public const string motif = @"^([\+]?33[-]?|[0])?[1-9][0-9]{8}$";

        public void Add(Class1 player)
        {
            if (ad.Count <= 2)
            {
                Class1 c = new Class1();
                // oneDayTeam.Add(new Player());



                Console.WriteLine("Enter customer id:");
                c.Cus_id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Customer Name:");
                c.Customer_name = Console.ReadLine();
                Console.WriteLine("Enter mobno:");
                c.number = Console.ReadLine();
                int l=(c.number).Length;
                if (l==10)
                {
                    Regex.IsMatch(c.number, motif);
                    Console.WriteLine("Mob number is valid !!");
                    ad.Add(c);
                    // player.prod = ad;
                    Console.WriteLine("Added successfully!!");
                    Console.WriteLine("------------------------------");


                }
                else
                {
                    Console.WriteLine("Mobile number is incorrect !!");
                }




            }
        

        }
        /*public void dis(List<Class1>ad)
         {
             foreach(var item in ad)
             {
                 Console.WriteLine(item.Cus_id);
                 Console.WriteLine(item.Customer_name);
                 Console.WriteLine(item.number);
             }
         }*/
        public List<Class1> GetAll()
        {

            foreach (var item in ad)
            {
                Console.WriteLine("Id:" + item.Cus_id);
                Console.WriteLine("Name:" + item.Customer_name);
                Console.WriteLine("Mobile num:" + item.number);
            }

            return ad;

        }

    }
}
