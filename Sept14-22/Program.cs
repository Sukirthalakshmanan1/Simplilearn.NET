using Movie_app;
using Newtonsoft.Json;

using System.Collections.Generic;
using System.IO;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace Movie_app { 
    internal class Program
{
    static void Main(string[] args)
    {
        CustomerUser c1 = new CustomerUser();
        c1.Id = 2018506128;
        c1.Password = "123456789";
        c1.validate();

        CustomerUser c2 = new CustomerUser();
        c2.Id = 9845612378;
        c2.Password = "123456789";
        c2.validate();


        FileStream fs = new FileStream(@"new.bin", FileMode.Create, FileAccess.Write);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(fs, c1);
        bf.Serialize(fs, c2);
        fs.Flush();
        fs.Close();
        fs.Dispose();
        FileStream fs1 = new FileStream(@"new.bin", FileMode.Open, FileAccess.Read);
        BinaryFormatter bf1 = new BinaryFormatter();
        CustomerUser[] c = new CustomerUser[2];
        for (int i = 0; i < 2; i++)
        {

            c[i] = (CustomerUser)bf1.Deserialize(fs1);
        }
            foreach (var item in c)
            {
                Console.WriteLine("Binary serialization:");
                Console.WriteLine("-----------------------------------------");

                Console.WriteLine("User Id:"+item.Id);
                Console.WriteLine("Password:"+item.Password);
                Console.WriteLine("Status:"+item.login);
                Console.WriteLine("Data and Time:"+item.date);
                Console.WriteLine("-----------------------------------------");

            }

            fs1.Flush();
        fs1.Close();
        fs1.Dispose();



        Searching s1 = new Searching();
        s1.initiate();
            Console.WriteLine("----------------------------");
            s1.DisplayMovies();
            Console.WriteLine("----------------------------");
            s1.search();
        FileStream fs2 = new FileStream(@"new1.bin", FileMode.Create, FileAccess.Write);
        BinaryFormatter w = new BinaryFormatter();
        w.Serialize(fs2, s1);
        fs2.Flush();
        fs2.Close();
        fs2.Dispose();
        FileStream fs3 = new FileStream(@"new1.bin", FileMode.Open, FileAccess.Read);
        BinaryFormatter read = new BinaryFormatter();
        Searching s2 = new Searching();
        s2 = (Searching)read.Deserialize(fs3);
            if (s2.Search != null)
            {
                foreach (Movie item in s2.Search)
                {
                    Console.WriteLine($"{item.name} {item.language} {item.genre} {item.stock}");


                }
            }
            else
            {
                Console.WriteLine("cannot found !!");
            }
            fs3.Flush();
        fs3.Close();
        fs3.Dispose();
            Console.WriteLine("----------------------------");


            Console.WriteLine("Add watchlist");
            Console.WriteLine("----------------------------");

            Watch cc = new Watch();
    mer:

        Console.WriteLine("enter name of movie");
        cc.Addtowatchlist();
            Console.WriteLine("----------------------------");

            Console.WriteLine("Enter yes to continue");
        string d = Console.ReadLine();
        if (d == "yes")
        {
            goto mer;
        }
            Console.WriteLine("Serialize using Json:");
        foreach (var item in cc.watchlist)
        {

            Console.WriteLine($"{item.Item1.name} {item.Item1.language} {item.Item1.genre} {item.Item1.stock} {item.Item2}");
                Console.WriteLine("----------------------------");

            }
            string s11 = JsonConvert.SerializeObject(cc);
        FileStream fs7 = new FileStream(@"new3.json", FileMode.Create, FileAccess.Write);
        StreamWriter w1 = new StreamWriter(fs7);
        w1.Write(s11);
        w1.Close();
        w1.Dispose();
        fs7.Close();
        fs7.Dispose();
        FileStream fs8 = new FileStream(@"new3.json", FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fs8);
        string s12 = sr.ReadToEnd();

        Watch s22 = JsonConvert.DeserializeObject<Watch>(s12);
            Console.WriteLine("Deserialize using Json!!");
        foreach (var item in s22.watchlist)
        {

            Console.WriteLine($"{item.Item1.name} {item.Item1.language} {item.Item1.genre} {item.Item1.stock} {item.Item2}");
        }
            Console.WriteLine("----------------------------");
            Console.WriteLine("XML Serialization and Deserialization:");
            Console.WriteLine("Enter Already seen movie release list:");
            cc.releaselist();
        List<Movie> dgg = new List<Movie>();
        foreach (var item in cc.release)
        {
            dgg.Add(item.Item1);
        }
        c1.alreadyseen = dgg;
        FileStream fs4 = new FileStream(@"new2.Xml", FileMode.Create, FileAccess.Write);
        System.Xml.Serialization.XmlSerializer xm = new System.Xml.Serialization.XmlSerializer(typeof(CustomerUser));
        xm.Serialize(fs4, c1);
        fs4.Flush();
        fs4.Close();
        fs4.Dispose();
        FileStream fs5 = new FileStream(@"new2.Xml", FileMode.Open, FileAccess.Read);
        System.Xml.Serialization.XmlSerializer ms = new System.Xml.Serialization.XmlSerializer(typeof(CustomerUser));
        var t = (CustomerUser)ms.Deserialize(fs5);
        Console.WriteLine("Retrieved Already seen movies !!");
            Console.WriteLine("----------------------------");

            foreach (var item in t.alreadyseen)
        {
            Console.WriteLine($"{item.name} {item.language} {item.genre} {item.stock}");
                Console.WriteLine("----------------------------");

            }
            fs5.Flush();
        fs5.Close();
        fs5.Dispose();
        Console.WriteLine("Enter the movie name to find Cost of movie you want to know:");
            Console.WriteLine("----------------------------");

            string id = Console.ReadLine();
        cc.totalcost(id);
        FileStream fs9 = new FileStream(@"b4.bin", FileMode.Create, FileAccess.Write);
        BinaryFormatter write1 = new BinaryFormatter();
        write1.Serialize(fs9, cc);
        fs9.Flush();
        fs9.Close();
        fs9.Dispose();
        FileStream fs81 = new FileStream(@"b4.bin", FileMode.Open, FileAccess.Read);
        BinaryFormatter read1 = new BinaryFormatter();

        var sii2 = (Watch)read.Deserialize(fs81);
        foreach (var item in sii2.total)
        {
            Console.WriteLine($"{item.Item1} {item.Item2} {item.Item3}");
                Console.WriteLine("----------------------------");

            }
            fs81.Flush();
        fs81.Close();
        fs81.Dispose();
            char v;
            do
            {
                Console.WriteLine("Enter your choice:\n 1.Add movie \n 2.Display movies");
                int n1 = Convert.ToInt32(Console.ReadLine());
                switch (n1)
                {
                    case 1:
                        s1.AddMovies();
                        
                        break;
                    case 2:
                        
                        s1.DisplayMovies();
                        break;
                }
                Console.WriteLine("Enter y to continue..");
                v = Convert.ToChar(Console.ReadLine());
            } while (v == 'y');





       Console.ReadKey();
    }
}
}