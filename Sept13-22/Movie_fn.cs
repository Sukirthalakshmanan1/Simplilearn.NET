using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    public class Movie_fn
    {
        public List<Movie_fn> ad1 = new List<Movie_fn>();
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

        public void Add(Movie_fn player)
        {
            if (ad1.Count <= 2)
            {

                // oneDayTeam.Add(new Player());

                Movie_fn m = new Movie_fn();

                Console.WriteLine("Enter   Movie id:");
                m.movie_id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Movie Name:");
                m.movie_name = Console.ReadLine();
                Console.WriteLine("Enter Language:");
                m.lang = Console.ReadLine();

                Console.WriteLine("Enter genre:");
                m.genres = Console.ReadLine();
                ad1.Add(m);
                // player.prod = ad;
                Console.WriteLine("Added successfully!!");
                Console.WriteLine("------------------------------");


            }
        }

        public void GetAll()
        {

            foreach (var item in ad1)
            {
                Console.WriteLine("Movie Id:" + item.id);
                Console.WriteLine("Novie Name:" + item.movie_name);
                Console.WriteLine("Language:" + item.lang);
                Console.WriteLine("Genre:"+item.Genres);
            }

          
                

        }
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

    }
    }
