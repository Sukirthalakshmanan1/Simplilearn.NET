using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractlib
{
    //3
    public class Savings : IBank
    {
        
        public Savings()
        {
            Console.WriteLine("Savings Account !!!");
            Console.WriteLine("-----------------------------");
        }

        public void Printbalance(int a)
        {
            Console.WriteLine("Print the balance:"+a);
            Console.WriteLine("-----------------------------");
        }
        //4
        public void CalculateInterest()
        {
            Console.WriteLine("To calculate Interest:");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Enter Principle amt:");
            int p1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no of years:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate of interest:");
            float r1 = Convert.ToSingle(Console.ReadLine());

            float Interst = (p1 * n1 * r1)/100;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Interest  is:"+Interst);
            
            Console.WriteLine("Interest to be paid !! ");
        }
    }
    public static class Extension2

    {
        static int AvailableBalace = 10000;

        //5
        public static void Withdraw(this Savings s1)
    {
        Console.WriteLine("Enter the amt to withdraw");
        Console.WriteLine("-----------------------------");
        int w = Convert.ToInt32(Console.ReadLine());
        if (w <= AvailableBalace)
        {
            AvailableBalace = AvailableBalace - w;
        }
        Console.WriteLine("Success !!!");
        Console.WriteLine("Total amt is:" + AvailableBalace);
        Console.WriteLine("-----------------------------");
    }
    //6,7
    public static void Deposit1(this Savings s1)
    {

       DateTime date1 = new DateTime(2022,5,2);
            //DateTime date1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Deposited Date is : " + date1);
        
        double val = DateTime.Today.Subtract(date1).TotalDays;

        Console.WriteLine("Time span b/w deposit date to till now is : " + val + " days !!");
        Console.WriteLine("-----------------------------");

        Console.WriteLine("Enter the amount to deposit:");
        int d = Convert.ToInt32(Console.ReadLine());
        AvailableBalace += d;
        Console.WriteLine("Depositted Successfully !!");
        Console.WriteLine("Amount present is" + AvailableBalace);
        Console.WriteLine("-----------------------------");
    }

}
}
