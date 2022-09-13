using Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movieslib
{
    public class User
    {
        private int id;

        public int movie_id
        {
            get { return id; }
            set { id = value; }
        }

        private string mov_name;

        public string movie_name
        {
            get { return mov_name; }
            set { mov_name = value; }
        }

        private string lang;

        public string Language
        {
            get { return lang; }
            set { lang = value; }
        }

        private string genres;

        public string Genres
        {
            get { return genres; }
            set { genres = value; }
        }

        private string login_id;

        public string Id
        {
            get { return login_id; }
            set { login_id = value; }
        }
        private string pass;

        public string Password
        {
            get { return pass; }
            set { pass = value; }
        }
        public void login()
        {
            Console.WriteLine("Enter user id:");
            login_id = Console.ReadLine();
            Console.WriteLine("Enter password :");
            pass = Console.ReadLine();
            if (login_id == "sukirthal1" && pass=="suki@123")
            {
                Console.WriteLine("Welcome {0}",login_id);
                Console.WriteLine("---------------------------------------------------");
                list();
            }
            else
            {
                Console.WriteLine("Incorrect user");
            }
        }

        public void list()
        {
            Console.WriteLine("1.Vivagam  Tamil  Thriller");
            Console.WriteLine("2.Captain  Tamil  Space thriller");
            Console.WriteLine("3.remo     Tamil  Romantic");
            Console.WriteLine("4.Don      Tamil  Comedy");
            Console.WriteLine("5.War      English Space thriller");
            Console.WriteLine("6.kodi     Hindi   Romantic");
            Console.WriteLine("7.kanchana Tamil   Horror");
            Console.WriteLine("8.sir      English Horror");
            Console.WriteLine("9.Dany     Tamil   crime thriller");
            Console.WriteLine("10.Trigger korean  crime thriller");





        }
        public List<Movie_fn> ad1 = new List<Movie_fn>();

        public void GetBylang(string lang)
        {
            var ti = ad1.Where(mi => mi.Language == lang).ToList();
            if (ti.Count > 0)
            {
                foreach (var item in ti)
                {
                    Console.WriteLine("Movie id:" + item.movie_id);
                    Console.WriteLine("Name:" + item.movie_name);
                    Console.WriteLine("Genre:" + item.Genres);
                }



            }
            else
            {
                Console.WriteLine("not found !!");
            }
        }
        public void GetBygenre(string g)
        {
            var ti = ad1.Where(mi => mi.Genres == g).ToList();
            if (ti.Count > 0)
            {
                foreach (var item in ti)
                {
                    Console.WriteLine("Movie id:" + item.movie_id);
                    Console.WriteLine("Name:" + item.movie_name);
                    Console.WriteLine("Language:" + item.Language);
                }



            }
            else
            {
                Console.WriteLine("not found !!");
            }
        }

        /* public static void addprod(List<Prod_3> list)
         {
             Console.WriteLine("Enter no of products to be added:");
             int n = Convert.ToInt32(Console.ReadLine());


             for (int i = 0; i < n; i++)
             {
                 list.Add(new Prod_3());



                 Console.WriteLine("Enter id:");
                 list[i].Id = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine("Enter Name:");
                 list[i].SName = Console.ReadLine();
                 Console.WriteLine("Enter cost:");
                 list[i].cost = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Added successfully!!");
                 Console.WriteLine("------------------------------");
             }

         }
         public static void disp(List<> list)
         {

             foreach (var item in list)
             {
                 Console.WriteLine("Product Id:" + item.Id);
                 Console.WriteLine("Product Name:" + item.Name);
                 Console.WriteLine("Cost :" + item.cost);

             }
             Console.WriteLine("------------------------------");

         }*/
        public void movies()
        {
            Console.WriteLine("Enter name:");
            movie_name = Console.ReadLine();
            movie_id = Convert.ToInt32(Console.ReadLine());
            lang = Console.ReadLine();
            genres = Console.ReadLine();
            Console.WriteLine("Movie name:" + movie_name);
            Console.WriteLine("Movie id:" + movie_id);
            Console.WriteLine("Language:" + lang);
            Console.WriteLine("Genres:" + genres);
            Console.WriteLine("-------------------");
        }
    }
}
