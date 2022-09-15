using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string c;
            Player play = new Player();
            play.M4();
            OneDayTeam team = new OneDayTeam();
            
            OneDayTeam.addplayer_1 c1 = new OneDayTeam.addplayer_1(team.Add);
            do
            {
                Console.WriteLine("Enter your choice:\n 1.To Add Player \n 2.To Remove Player by Id \n 3.Get Player By Id \n 4.Get Player by Name \n 5.Get All Players ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                switch (n1)
                {
                    case 1:
                        c1(play);
                       // team.Add(play);

                        break;
                    case 2:

                        Console.WriteLine("Enter the Player id : ");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        
                        team.Remove(id1);
                        
                        break;
                    case 3:
                        Console.WriteLine("Enter the Player id : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("----------------------------------");

                        team.GetPlayerById(id);

                        break;
                    case 4:
                        Console.WriteLine("Enter the name: ");
                        string s = Console.ReadLine();
                        Console.WriteLine("----------------------------------");

                        team.GetPlayerByName(s);

                         break;
                    case 5:
                        team.GetAllPlayers();
                         break;


                }
                Console.WriteLine("Do you want to continue press yes/no..");
                c = Console.ReadLine();
            } while (c == "yes" );
            Console.ReadLine();
        }
    }
}
