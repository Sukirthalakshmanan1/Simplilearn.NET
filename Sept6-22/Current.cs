using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractlib
{
    //3
    public class Current:IBank
    {
       // static int amt = 10000;
        public Current()
        {
            Console.WriteLine("Current account !!");
            Console.WriteLine("-----------------------------");
        }
        public void Printbalance(int amt)
        {
            Console.WriteLine("Print the balance:" + amt);
            Console.WriteLine("-----------------------------");
        }
        //4
        public void CalculateInterest()
        {
            Console.WriteLine("To calculate Interest:");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Enter Principle amt:");
            int p2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no of years:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate of interest:");
            float r2 = Convert.ToSingle(Console.ReadLine());

            float o = (p2 * n2 * r2)/100;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Interest is:"+o);
        }
    }
    public static class Extension1

    {
        static int AvailableBalace = 10000;

        //5

        public static void Withdraw1(this Current c1)
        {
            Console.WriteLine("Enter the amt to withdraw:");
            Console.WriteLine("-----------------------------");
            int w = Convert.ToInt32(Console.ReadLine());
            if (w <= AvailableBalace)
            {
                AvailableBalace = AvailableBalace - w;
            }
            Console.WriteLine("Success !!!");
            Console.WriteLine("Total Balance:" + AvailableBalace);
            Console.WriteLine("-----------------------------");
        }
        //6,7
        public static void Deposit(this Current c1)
        {
            DateTime date1 = new DateTime(2022, 8, 1);
            Console.WriteLine("Deposit date is: " + date1);

            double val = DateTime.Today.Subtract(date1).TotalDays;
            Console.WriteLine("Time span b/w deposit date to today is : " + val + " days !!");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Enter the amount to deposit:");
            Console.WriteLine("-----------------------------");
            int d = Convert.ToInt32(Console.ReadLine());
            AvailableBalace += d;
            Console.WriteLine("Depositted Successfully !!");
            Console.WriteLine("Amount present is:" + AvailableBalace);
            Console.WriteLine("-----------------------------");
        }
    }
    }
