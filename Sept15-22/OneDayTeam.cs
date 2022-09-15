using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class OneDayTeam : Player,ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();
        Player p = new Player();

        public static int Capacity = 11;

        public delegate void addplayer_1(Player y);
        public OneDayTeam()
        {
            Console.WriteLine("Team Capacity: {0}", OneDayTeam.Capacity);
            Console.WriteLine("-----------------------------");
        }

        public void Add(Player player)
        {
            if (oneDayTeam.Count < Capacity)
            {
                Player p = new Player();


                Console.WriteLine("Enter id:");
                p.Player_ID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name:");
                p.Player_Name = Console.ReadLine();
                Console.WriteLine("Enter age:");
                p.PlayerAge = Convert.ToInt32(Console.ReadLine());
                oneDayTeam.Add(p);
                player.prod = oneDayTeam;
                Console.WriteLine("Added successfully!!");
                Console.WriteLine("------------------------------");
                // return player;


            }
            else
            {
                Console.WriteLine("Player cannot be added !! already 11 members are there");
                Console.WriteLine("----------------------------------");

               
            }
        }

        public List<Player> GetAllPlayers()
        {
            Console.WriteLine("List of members:");
            Console.WriteLine("----------------------------------");

            foreach (var item in oneDayTeam)
            {
                Console.WriteLine("Player id:" + item.Player_ID);
                Console.WriteLine("Player name:" + item.Player_Name);
                Console.WriteLine("Age:" + item.PlayerAge);
                Console.WriteLine("----------------------------------");

            }

            return oneDayTeam;

        }

        public Player GetPlayerById(int playerId)
        {
            var ti = oneDayTeam.Where(mi => mi.Player_ID == playerId).ToList();

            if (ti.Count > 0)
            {
                foreach (var item in ti)
                {
                    Console.WriteLine("Player id:" + item.Player_ID);
                    Console.WriteLine("Name:" + item.Player_Name);
                    Console.WriteLine("Age:" + item.PlayerAge);
                    Console.WriteLine("----------------------------------");

                }


                return p;
            }



            else
            {
                Console.WriteLine($"Id {playerId} not found !!");
                //  return ti[0];
                Console.WriteLine("----------------------------------");

                return p;
            }




        }

        public Player GetPlayerByName(string playerName)
        {

            var ti = oneDayTeam.Where(mi => mi.Player_Name == playerName).ToList();
            if (ti.Count > 0)
            {
                foreach (var item in ti)
                {
                    Console.WriteLine("Player id:" + item.Player_ID);
                    Console.WriteLine("Name:" + item.Player_Name);
                    Console.WriteLine("Age:" + item.PlayerAge);
                    Console.WriteLine("----------------------------------");
                }

            }
            else
            {

                Console.WriteLine($"Player name {playerName} not found !!");


            }
            return p;




        }

        public void Remove(int playerId)
        {
            //oneDayTeam = oneDayTeam.Where(m1 => m1.Player_ID != playerId).ToList();

            var p1 = oneDayTeam.Find(item => item.Player_ID == playerId);

            if (p1 != null)
            {
                oneDayTeam.Remove(p1);

                Console.WriteLine($"Player ID {playerId} Removed Successfully!!");
                
            }

            else
            {
                Console.WriteLine($"Player ID {playerId} Not found !");
            }

            Console.WriteLine("----------------------------------");

        }


    }
   
}
