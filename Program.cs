using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pgm2
{
    internal class Program
    {
           
            //pbm stmt 1
            /*static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
         static void Swapvalues( int x,  int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            int a, b; 
            //int temp = 0;
            
            Console.WriteLine("Enter two numbers to swap:");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            Swap(ref a, ref b);
            Console.WriteLine("After Swapping by Reference:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("After Swapping by values:");
            Swapvalues(a,b);
            Console.WriteLine(a);
            Console.WriteLine(b);


            Console.ReadKey();*/


            //problem stmt 2
            /*static void Main(string[] args)
        {
         int i, j, k;
            Console.WriteLine("Enter 3 numbers to multiply:");
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            int multiply = i * j * k;
            Console.WriteLine(i+"*"+j+"*"+k+"="+multiply);
            Console.ReadKey();}*/

        //pbm stmt 3
        /*static void Main(string[] args)
        {
            double i,j,res;
            Console.WriteLine("Enter two numbers:");
            i= Convert.ToInt32(Console.ReadLine());
            j= Convert.ToInt32(Console.ReadLine());
             res=i+j;
            Console.WriteLine("{0}+{1} ={2}",i,j,res);
            res=i-j;
            Console.WriteLine("{0}-{1} ={2}",i,j,res);
            res=i*j;
            Console.WriteLine("{0}*{1} ={2}",i,j,res);
            res=i/j;
            Console.WriteLine("{0}/{1} ={2}",i,j,res);
            Console.ReadKey();
        }*/

        //pbm stmt 4
        /*static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Enter 4 numbers to find average of them:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            double res = a + b + c + d;
            Console.WriteLine("Average is " +res+"/4");
            Console.ReadKey();
        }*/

        //pbm stmt 5
        /*static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Enter x y and z:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
            int res = (x + y) * z;
            int sum = (x * y) + (y * z);
            Console.WriteLine("result of (x+y).z is "+res);
            Console.WriteLine("Result of (x.y)+(y.z ) is "+sum);
            Console.ReadLine();
        }*/

        //pbm stmt 6
       /* static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter your age:");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look older than "+i);
            Console.ReadKey();
        }*/

        //pbm stmt 7 --2525 pbm
        /*static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Enter a digit: ");
            n = Convert.ToInt32(Console.ReadLine());

            
            Console.Write(n);
            Console.Write(" ");
            Console.Write(n);
            Console.Write(" ");
            Console.Write(n);
            Console.Write(" ");
            Console.Write(n);
            Console.WriteLine();

            
            Console.Write(n);
            Console.Write(n);
            Console.Write(n);
            Console.WriteLine(n);
            Console.WriteLine();
            
            Console.WriteLine("{0} {0} {0} {0}", n);

            Console.WriteLine("{0}{0}{0}{0}", n);
            Console.ReadKey();

        }*/

        //pbm stmt 8 -- 5555 pbm
        /*static void Main(string[] args)
        {
            int x;

            Console.Write("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0}{0}{0}", x);
            Console.ReadKey();
        }*/

        //pbm stmt 9 -- Celsius to kelvin and fahrenheit
        /*static void Main(string[] args)
        {
            Console.Write("Enter the Celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
            Console.ReadKey();
        }*/


        //pbm stmt 10 --Check if one is negative and one is positive

       /* static void Main(string[] args)
        {
            Console.WriteLine("Enter first Integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive and return the output:");
            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
            Console.ReadKey();
        }*/
   
   //pbm stmt 11 --both are positive
   /*static void Main(string[] args)
        {
            Console.WriteLine("Enter first Integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second Integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if both are positive:");
            Console.WriteLine((x > 0 && y > 0) );
            Console.ReadKey();
        }*/

        //pbm stmt 12 ---string is null or empty

       /* static void Main(string[] args)
        {
            Console.WriteLine("Enter String:");
            string s = Console.ReadLine();
            bool b = string.IsNullOrEmpty(s);
            Console.WriteLine(b);
            
            Console.ReadKey();
        }*/

        //pbm stmt 13 ----km to m and  m to km
        /*public static double MToKm(double m)
        {
            double KM = 0;

            KM = m / 1000;

            return KM;
        }

        public static double KmToMeter(double km)
        {
            double d= 0;

            d = km * 1000;

            return d;
        }


        static void Main(string[] args)
        {
            double meter = 0;
            double km = 0;

            Console.Write("Enter the distance in meter : ");
            meter = double.Parse(Console.ReadLine());

            km = MToKm(meter);
            Console.WriteLine("Kilometer : " + km + " km");

            Console.Write("Enter the distance in kilometer: ");
            km = double.Parse(Console.ReadLine());

            meter = KmToMeter(km);
            Console.WriteLine("Meter : " + meter + " m");
            Console.ReadKey();


        }*/

        //pbm stmt 14 -- celsius to fahrenheit
        /*static void Main(string[] args)
        {
            double f;

            double c ;
            Console.WriteLine("Enter Celsius:");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Celsius: " + c);

            f = (c * 9) / 5 + 32;
            Console.WriteLine("Converted to Fahrenheit: " + f);

            Console.ReadLine();
        }
        */

        // pbm stmt 15 -- USD to INR
        static void Main(string[] args)
        {
            double USD = 0;
            double inr = 0;
            double amt = 0;

            Console.Write("Enter amount in USD: ");
            USD = double.Parse(Console.ReadLine());

            Console.Write("Enter the USD value :");
           amt = double.Parse(Console.ReadLine());

            inr = USD * amt;
            Console.WriteLine("USD " + USD + " to INR value is " + inr);
            Console.ReadKey();
        }
        

   

        
    }
}
