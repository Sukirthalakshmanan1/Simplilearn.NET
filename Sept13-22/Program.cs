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
            Movie movie = new Movie();
            User1 user1 = new User1();
            char c,c1,s;

            

            Console.WriteLine("Enter type");
            user1.Type = Console.ReadLine();

            user1.initiate();
                List<Movie> ss = new List<Movie>();
                double total = 0;
                int Count1 = 0;
            sed:
                Console.WriteLine("Adding");
                ss = user1.adding(ss, user1.Type);
                Count1++;
                user1.rented = ss;
                if (ss.Count == Count1)
                {
                    Console.WriteLine("Enter the rental year");
                    int mm = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the rental month");
                    int mi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the rental date");
                    int min = Convert.ToInt32(Console.ReadLine());
                    DateTime top = new DateTime(mm, mi, min);
                    user1.rentaldate = top;
                    Console.WriteLine("Enter the releasing year");
                    int i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the releasing month");
                    int im = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the releasing date");
                    int imn = Convert.ToInt32(Console.ReadLine());
                    DateTime pot = new DateTime(i, im, imn);
                    user1.releasingdate = pot;
                    Console.WriteLine("Enter the cost");
                    user1.Cost = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Total cost for this movie", +user1.TotalCost());
                    total += user1.TotalCost();
                    Console.WriteLine("Enter Yes to further rental");
                    string u1 = Console.ReadLine();
                    if (u1 == "Yes")
                    {
                        goto sed;
                    }
                }
                Console.WriteLine("Stocks after rented");

                foreach (var item in user1.dbmovies)
                {
                    Console.WriteLine($"{item.Name} {item.stock}");
                }

                ss = user1.releasing(ss);
                user1.rented = ss;
                Console.WriteLine("Total cost" + total);
                foreach (var item in user1.rented)
                {
                    Console.WriteLine(item.Name);
                }

                Console.ReadLine();

            
            



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
                            Console.WriteLine("Enter your choice:\n 1.Search movies by language \n 2.search by genres \n 3.Category \n 4.Remove \n 5.Dispaly  \n 7.Total cost \n 8.Change Password \n 9.view profile ");
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
                                case 3:
                                    user1.Addition(movie);
                                    break;
                                case 4:
                                    user1.Removing(movie);
                                    break;
                                case 5:
                                    user1.Display();
                                    break;
                                
                                
                                case 7:
                                    user1.TotalCost();
                                    break;
                                case  8:
                                    v.change();
                                    break;
                                case 9:
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
                            Console.WriteLine("Enter your choice:\n 1.Add customer \n 2.Add movies \n 3.search movies \n 4.Profile");
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
                                case 4:
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
