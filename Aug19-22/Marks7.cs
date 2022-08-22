using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_firstpgm
{
    internal class Marks7
    {
        static void Main(string[] args)
        {
            double  phy, chem, maths, total;
            double per;
            string s, rank;

            
            Console.Write("Enter the Name of the Student :");
            s = Console.ReadLine();

            Console.Write("Enter marks in Physics : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks in Chemistry : ");
            chem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks in Maths: ");
            maths = Convert.ToInt32(Console.ReadLine());

            total = phy + chem + maths;
            per = total / 3.0;
            if (per > 60)
                rank = "First";
            else
            if (per <= 60 && per > 45)
                rank = "Second";
            else
                if (per <= 45 && per >=35)
                rank = "Third ";
            else
                rank = "Fail";

            Console.Write("Name of Student : {0}\n",s);
            Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Maths : {2}\n", phy, chem, maths);
            Console.Write("Total Marks = {0}\nPercentage = {1}\n Rank = {2}\n", total, per, rank);
            Console.ReadKey();
        }
    }
}
