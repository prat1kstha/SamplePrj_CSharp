//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Ex1
//    {
//        static void Main(string[] args)
//        {
//            /*1. A simple calculator that adds two numbers.*/
//            Console.WriteLine("This is a simple addition calculator.");

//            Console.WriteLine("Enter your 1st Number: ");
//            double x = double.Parse(Console.ReadLine());

//            Console.WriteLine("Enter your 2nd Number: ");
//            double y = double.Parse(Console.ReadLine());

//            double z = Math.Round(x + y, 2);

//            Console.WriteLine("{0} + {1} = {2}", x, y, z);

//            /*2. Calculate the cost of carpeting of a room for a given constant price per sqr. foot.*/
//            Console.WriteLine("This calculates the total cost of carpeting a room for a given area.");

//            Console.WriteLine("Length of the room: ");
//            double l = double.Parse(Console.ReadLine());

//            Console.WriteLine("Width of the room: ");
//            double w = double.Parse(Console.ReadLine());

//            double a = l * w;
//            const double price = 50.30;

//            Console.WriteLine("Total Cost for Carpeting: Rs. {0}", Math.Round(a * price));


//            /*Time Cast*/
//            Console.WriteLine("This converts a given time in minutes to hour and minutes.");

//            Console.WriteLine("Enter the time in minutes: ");
//            int input_min = int.Parse(Console.ReadLine());

//            int hr, min;

//            hr = input_min / 60;
//            min = input_min % 60;

//            Console.WriteLine("{0} Hr {1} Min", hr, min);
//        }
//    }
//}
