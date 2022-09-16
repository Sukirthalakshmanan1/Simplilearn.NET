using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Movie_app
{
    [Serializable()]
    public class Movie
    {
        public Movie()
        {

        }
        public string name
        {
            get;
            set;
        }
        public int stock { get; set; }
        public string language { get; set; }
        public string genre { get; set; }
        
        public Movie(string n, string language, string genre, int q4)
        {
            name = n;
            this.language = language;
            this.genre = genre;
            stock = q4;

        }
        
    }

    [Serializable()]
    public class Searching
    {
        public List<Movie> Search
        {
            get;
            set;
        }
        public static List<Movie> movies = new List<Movie>();
        public void initiate()
        {
            movies.Add(new Movie("kala", "Tamil", "Action", 200));
            movies.Add(new Movie("Imaika nodigal", "Tamil", "Thriller", 140));
            movies.Add(new Movie("Don", "Telugu", "Drama", 150));
            movies.Add(new Movie("Remo", "Malayalam", "Romantic", 80));
            movies.Add(new Movie("Diya", "Kannada", "Drama", 304));
            
        }

        
        public void search()
        {
            char c;
            do
            {
                Console.WriteLine("Enter your choice to search :\n 1.Name\n 2.Language\n 3.Genre");
                int p = Convert.ToInt32(Console.ReadLine());

                switch (p)
                {
                    case 1:
                        Console.WriteLine("Enter the movie name to search");
                        string q = Console.ReadLine();
                        var pt = movies.Where(pi => pi.name == q).ToList();
                        if (pt.Count>0)
                        {
                           
                            foreach (var item in pt)
                            {
                                Console.WriteLine("Movie id:" + item.name);
                                Console.WriteLine("Name:" + item.language);
                                Console.WriteLine("Genre:" + item.genre);
                            }
                            Search = pt;
                        }
                        else
                        {
                            Console.WriteLine("Movie unavailable");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the movie language to search:");
                        string qq = Console.ReadLine();
                        var tp = movies.Where(pi => pi.language == qq).ToList();
                        if (tp.Count>0)
                        {
                            Search = tp;
                            foreach (var item in tp)
                            {
                                Console.WriteLine("Movie id:" + item.name);
                                Console.WriteLine("Name:" + item.language);
                                Console.WriteLine("Genre:" + item.genre);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Language unavailable !!!");
                        }
                        
                        break;
                    case 3:
                        Console.WriteLine("Enter the movie genre to search:");
                        string qqq = Console.ReadLine();
                        var tpp = movies.Where(pi => pi.genre == qqq).ToList();
                        if (tpp.Count >0)
                        {
                            Search = tpp;
                            foreach (var item in tpp)
                            {
                                Console.WriteLine("Movie id:" + item.name);
                                Console.WriteLine("Name:" + item.language);
                                Console.WriteLine("Genre:" + item.genre);
                            }

                        }
                        else
                        {
                            Console.WriteLine("Type not available ...");
                        }
                        break;

                }
                Console.WriteLine("Press y to continue..");
                c = Convert.ToChar(Console.ReadLine());
            } while (c == 'y');
        }
        public void AddMovies()
        {
            Movie m = new Movie();
            Console.WriteLine("Enter movie name:");
            m.name = Console.ReadLine();
            Console.WriteLine("Enter movie language:");
            m.language = Console.ReadLine();
            Console.WriteLine("Enter movie genre:");
            m.genre = Console.ReadLine();
            Tuple<string, string, string> mi = Tuple.Create<string, string, string>(m.name, m.language, m.genre);
            Predicate<Tuple<string, string, string>> k = (i) =>
            {
                int flag = 0;
                foreach (var item in movies)
                {
                    if (item.name == i.Item1 && item.language == i.Item2 && item.genre == i.Item3)
                    {
                        flag = 1;
                        break;
                    }

                }
                if (flag == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            if (k(mi))
            {
                Console.WriteLine("Already Exists !!!");
            }
            else
            {
                movies.Add(m);

            }
        }
        public void DeleteMovies()
        {

            Movie md = new Movie();
            Console.WriteLine("Enter movie name");
            md.name = Console.ReadLine();
            Console.WriteLine("Enter movie language");
            md.language = Console.ReadLine();
            Console.WriteLine("Enter movie genre");
            md.genre = Console.ReadLine();
            foreach (var item in movies)
            {
                if (item.name == md.name && item.language == md.language && item.genre == md.genre)
                {

                    movies.Remove(item);
                }

            }

        }

        public void DisplayMovies()
        {
            foreach (var item in movies)
            {
                Console.WriteLine($"{item.name} {item.language} {item.genre}");
            }
        }
    }
    [Serializable()]
    public class CustomerUser : Searching
    {

        public long Id { get; set; }

        public string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string login
        {
            get;
            set;
        }
        public DateTime date
        {
            get { return DateTime.Now; }
        }
        public bool validate()
        {
            if (Id == 2018506128 && Password == "123456789")
            {
                login = "true";
                return true;
            }
            else
            {
                login = "false";
                return false;
            }
        }


        public List<Movie> alreadyseen
        {
            get;
            set;
        }





    }
    [Serializable()]
    public class Watch : Searching
    {
        public List<Tuple<Movie, DateTime>> watchlist = new List<Tuple<Movie, DateTime>>();
        public List<Tuple<Movie, int>> release = new List<Tuple<Movie, int>>();
        public List<Tuple<string, int, double>> total = new List<Tuple<string, int, double>>();
        public void Addtowatchlist()
        {
            string s = Console.ReadLine();
            var pi = movies.Where(p => p.name == s).ToList();
            if (pi.Count>0 )
            {
                foreach (Movie item in pi)
                {

                    Console.WriteLine("Movie name which will be removed from stock:"+item.name);

                    movies.Remove(item);
                    item.stock = item.stock - 1;
                    Console.WriteLine("Enter year:");
                    int yr1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter month:");
                    int mon1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter date:");
                    int dt1 = Convert.ToInt32(Console.ReadLine());
                    DateTime t1 = new DateTime(yr1, mon1, dt1);

                    Tuple<Movie, DateTime> ji = Tuple.Create<Movie, DateTime>(item, t1);
                    movies.Add(item);
                    watchlist.Add(ji);


                }

            }
            else
            {
                Console.WriteLine("Cannot be added");
            }

        }
        public void releaselist()
        {

            string cp = Console.ReadLine();
            Tuple<Movie, DateTime> k = null;
            foreach (var item in watchlist)
            {
                if (cp == item.Item1.name)
                {
                    k = item;

                    movies.Remove(item.Item1);
                    item.Item1.stock = item.Item1.stock + 1;

                    Console.WriteLine("Enter year:");
                    int yr = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter month:");
                    int mon = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter date:");
                    int dt = Convert.ToInt32(Console.ReadLine());
                    DateTime t = new DateTime(yr, mon, dt);
                    TimeSpan ts = t - item.Item2;
                    Tuple<Movie, int> poi = Tuple.Create<Movie, int>(item.Item1, ts.Days);
                    release.Add(poi);
                    movies.Add(item.Item1);


                }


            }
            watchlist.Remove(k);
        }
        public void totalcost(string p)
        {
            int flag = 0;
            foreach (var item in release)
            {
                if (p == item.Item1.name)
                {
                    flag = 1;
                    Console.WriteLine("Movie name:"+item.Item1.name);
                    Console.WriteLine("Enter the cost for one day:");
                    double Cost = Convert.ToInt32(Console.ReadLine());
                    double k = 0.18 * Cost;
                    double ty = item.Item2 * 0.01 * Cost;
                    double yt = k + ty + Cost;
                    Console.WriteLine($"GST is {k}");
                    Console.WriteLine($"Bluray cost is {ty}");
                    Console.WriteLine("Total cost is:" + " " + yt);
                    Tuple<string, int, double> k2 = Tuple.Create(item.Item1.name, item.Item2, yt);

                    total.Add(k2);
                }
            }
            foreach (var item in watchlist)
            {
                if (p == item.Item1.name)
                {
                    Console.WriteLine(item.Item1.name);
                    Console.WriteLine("Enter the cost for one day:");
                    double Cost = Convert.ToInt32(Console.ReadLine());
                    TimeSpan tu = DateTime.Now - item.Item2;
                    double k = 0.18 * Cost;
                    double ty = (tu.Days) * 0.01 * Cost;
                    double yt = k + ty + Cost;
                    Console.WriteLine($"GST is {k}");
                    Console.WriteLine($"Bluray cost is {ty}");
                    Console.WriteLine("Total cost is" + " " + yt);
                    Tuple<string, int, double> k2 = Tuple.Create(item.Item1.name, tu.Days, yt);

                    total.Add(k2);
                }
                else if (flag != 1)
                {
                    foreach (var item1 in movies)
                    {
                        if (p == item1.name)
                        {

                            Console.WriteLine(item1.name);
                            Console.WriteLine("Enter the cost for one day");
                            double Cost = Convert.ToInt32(Console.ReadLine());

                            double k = 0.18 * Cost;
                            double ty = 0 * 0.01 * Cost;
                            double yt = k + ty + Cost;
                            Console.WriteLine($"GST is {k}");
                            Console.WriteLine($"Bluray cost is {ty}");
                            Console.WriteLine("Total cost is" + " " + yt);
                            Tuple<string, int, double> k2 = Tuple.Create(item.Item1.name, 0, yt);

                            total.Add(k2);
                        }
                    }

                }
            }
        }


    }
}