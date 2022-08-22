using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_firstpgm
{
    internal class Hit_miss16
    {
        static void Main(string[] args)
        {
            int sc = 100;
            string word;
            Console.WriteLine("Enter HIT or Miss");
            for (int i = 1; i <= 4; i++)
            {
                word = Console.ReadLine();
                if (word == "hit" || word =="HIT")
                {
                    sc += 10;
                }
                else
                {
                    sc = sc - 20;
                }
            }
            Console.WriteLine("The final score is "+sc);
            Console.ReadLine();

        }
    }
}
