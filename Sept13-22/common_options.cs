using Admin;
using Movieslib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class common_options
    {
        public void change()
        {
            User u = new User();
            string s;
            if (u.Password == "suki@123")
            {
                Console.WriteLine("Enter new password:");
                s=Console.ReadLine();
                Console.WriteLine("password changed successfully !");
            }
            else
            {
                Console.WriteLine("Password cannot be changed !!");
            }
            
        }
        public List<Movie_fn> ob = new List<Movie_fn>();
        public void GetAll()
        {

            foreach (var item in ob)
            {
                Console.WriteLine("Movie Id:" + item.movie_id);
                Console.WriteLine("Novie Name:" + item.movie_name);
                Console.WriteLine("Language:" + item.Language);
                Console.WriteLine("Genre:" + item.Genres);
            }




        }
    }
}
