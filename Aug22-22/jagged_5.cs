using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist_11
{
    internal class jagged_5
    {
        static void Main(string[] args)
        {
            int[][] classroom = new int[4][];

            classroom[0] = new int[] { 10, 20};
            classroom[1] = new int[] { 100,  400, 500 };
            classroom[2] = new int[] { 20, 30,45 };
            classroom[3] = new int[4] { 50,45,80,100 };

            for (int i = 0; i < classroom.Length; i++)
            {
                Console.WriteLine("Classroom ({0})  ", i);
                for (int j = 0; j < classroom[i].Length; j++)
                {
                    Console.Write(classroom[i][j] + "\t ");
                }
                Console.WriteLine();

            }




            Console.Read();
        }
    }
}
