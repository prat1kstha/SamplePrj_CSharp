//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Variables
//    {
//        /*Ex1: Create a console-based application whose Main() method asks the user to input an integer
//         * and then calls a method named MultiplicationTable(), which displays the results of
//         * multiplying the integer by each of the numbers 2 through 10
//         */

//        /*Ex2: Create a console-based program whose Main() method prompts the user for an integer value and, in turn,
//        * passes the value to a method that squares the number and to a method that cubes the number. The Cube()
//        * method should call the Square() method. The Main() method displays the resulrs returned from each of the
//        * methods
//        */

//        /*Create a method named Sum() that accepts any number of integer parameters and displays their sum. Write
//         * a Main() method that demonstrates the Sum() method works correctly when passed one, three, or five integers,
//         * or an array of ten integers
//         */


//        static void Main(string[] args)
//        {  
//            Console.Write("Enter a number: ");
//            int num = int.Parse(Console.ReadLine());

//            /*Ex1*/
//            Console.WriteLine("Ex1");
//            MultiplicationTable(num);

//            /*Ex2*/
//            Console.WriteLine("Ex2");
//            int cube = Cube(num);
//            int sqr = Square(num);
//            Console.WriteLine("The square of the number is {0}", sqr);
//            Console.WriteLine("The cube of the number is {0}", cube);

//            /*Ex3*/
//            Console.WriteLine("Ex3");
//            Sum(10);
//            Sum(5, 6, 7);
//            Sum(1, 2, 3, 4, 5);

//            int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
//            Sum(numArray);

//        }

//        public static int Cube(int x)
//        {
//            int cube = Square(x) * x;
//            return cube;
//        }

//        public static int Square(int x)
//        {
//            int sqr = x * x;
//            return sqr;
//        }

//        public static void MultiplicationTable(int num)
//        {
//            for (int i = 2; i <= 10; i++)
//            {
//                Console.WriteLine("{0} * {1} = {2}", num, i, num* i);
//            }
//        }

//        public static void Sum(params int[] n)
//        {
//            int ans= 0;
//            for(int i = 0; i<n.Length; i++)
//            {
//                ans += n[i];
//            }
//            Console.WriteLine("The sum of the numbers is {0}", ans);
//        }
//    }
//}
