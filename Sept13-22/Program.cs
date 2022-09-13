using Admin;
using Common;
using Microsoft.Win32;
using Movieslib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User ob = new User();
            Class1 cc = new Class1();
            customer cc1 = new customer();
            Movie_fn m = new Movie_fn();
            common_options v = new common_options();

            char c,c1,s;
            do
            {
                Console.WriteLine("Enter your choice:\n 1.UserModule \n 2.Admin");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        
                        ob.login();
                        //ob.list();
                        Console.WriteLine("---------------------------------------------------------");

                        do
                        {
                            Console.WriteLine("Enter your choice:\n 1.Search movies by language \n 2.search by genres \n 3.Category \n 4.Change Password \n 5.view profile ");
                            int n1 = Convert.ToInt32(Console.ReadLine());
                             switch (n1)
                            {
                                case 1:
                                    Console.WriteLine("Enter language:");
                                    string l = Console.ReadLine();
                                    m.GetBylang(l);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter genre:");
                                    string a = Console.ReadLine();
                                    m.GetBygenre(a);
                                    break;
                                case 4:
                                    v.change();
                                    break;
                                case 5:
                                    cc1.GetAll();
                                    break;

                            }
                            Console.WriteLine("Press y to continue in user module..");
                            s = Convert.ToChar(Console.ReadLine());
                        } while (s == 'y');
                        break;
                    case 2:
                         do
                        {
                            Console.WriteLine("Enter your choice:\n 1.Add customer \n 2.Add movies \n 3.search movies \n 4.Update movies \n 5.Approve rentals \n 6.Assign movies \n 7.Pending \n 8.Profile");
                            int n2 = Convert.ToInt32(Console.ReadLine());
                            switch (n2)
                            {
                                case 1:
                                    cc1.Add(cc);
                                    break;
                                case 2:
                                    
                                    m.Add(m);
                                    m.GetAll();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter language:");
                                    string l = Console.ReadLine();
                                    m.GetBylang(l);
                                    break;
                                case 8:
                                    cc1.GetAll();
                                    break;
                            }
                            Console.WriteLine("Do u want to continue in admin block ..press y or Y !!");
                            c1 = Convert.ToChar(Console.ReadLine());

                        } while (c1 == 'Y' || c1 == 'y');

                            break;
                        }
                Console.WriteLine("Do u want to continue ..press y or Y !!");
                        c = Convert.ToChar(Console.ReadLine());

                } while (c == 'Y' || c == 'y') ;


            
            Console.ReadLine();
        }
    }
}
