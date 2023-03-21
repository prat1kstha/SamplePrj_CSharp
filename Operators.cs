//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Operators
//    {
//        static void Main(string[] args)
//        {
//            //Arithmetic Operator/
//            double x, y;
//            x = 10.0;
//            y = 12.0;

//            Console.WriteLine(x + " + " + y + " = " + Math.Round(x + y, 2));
//            Console.WriteLine(x + " - " + y + " = " + Math.Round(x - y, 2));
//            Console.WriteLine(x + " * " + y + " = " + Math.Round(x * y, 2));
//            Console.WriteLine(x + " / " + y + " = " + Math.Round(x / y, 2));

//            //Incremental Value
//            int a = 5;
//            int b = 7;
//            int c = a++;
//            int d = ++b;
//            Console.WriteLine("c = {0}, a = {1}", c, a);
//            Console.WriteLine("d = {0}, b = {1}", d, b);

//            //Ternary Operator
//            int number = 10;
//            bool IsNumber10 = number == 10 ? true : false;

//            Console.WriteLine("Number == 10 is {0}", IsNumber10);

//            //NULL Coalescing Operator
//            int? TIcketsOnSale = null;
//            int AvailableTickets = TIcketsOnSale ?? 0;
//            Console.WriteLine("Available Tickets: {0}", AvailableTickets);
//        }
//    }
//}