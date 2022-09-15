using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Player
    {
		private int playerid;

		public int Player_ID
		{
			get { return playerid; }
			set { playerid = value; }
		}

        private string playername;

        public string  Player_Name
        {
            get { return playername; }
            set { playername = value; }
        }

        private int age;

        public int PlayerAge
        {
            get { return age; }
            set { age = value; }
        }
        public List<Player> prod
        {
            get;
            set;
        }

    }
    public static class Extension2

    {
        public static void M4(this Player ss)
        {
            Console.WriteLine("Player and Team Requirements");
            Console.WriteLine("-----------------------------");
        }

    }
}
