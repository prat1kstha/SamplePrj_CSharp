//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Ex6_1
//    {
//        static void Main(string[] args)
//        {
//            /* Create a class name Square that contains fields for area and the length 
//             * of a side and whose constructor requires a parameter for the length of
//             * one side of a Square. The constructor assigns its parameter to the length of the Square's
//             * side field and calls a private method that computes the area field. Also include read-only
//             * properties to get a Sqaure's side and area. In the main method create an array of ten Sqare objects with sides that have values 
//             * of 1 through 10. Display the values for each Square
//             */

//            ClassSquare[] s = new ClassSquare[10];

//            for (int i = 1; i <= 10; i++)
//            {
//                s[i - 1] = new ClassSquare(i);
//                Console.WriteLine("Length of side of square: {0}, and Area: {1}", s[i - 1].Length, s[i-1].Area);
//            }
//        }
//    }
//}
