//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Array_Methods
//    {
//        static void Main(string[] args)
//        {
//            /*Binary Search*/
//            int[] myArray = { 10, 15, 20, 25, 30, 35, 40 };
//            Console.WriteLine("Enter a number to search: ");
//            int num = int.Parse(Console.ReadLine());

//            int answer = Array.BinarySearch(myArray, num);

//            if (answer < 0)
//            {
//                Console.WriteLine("The number does not exist.");
//            }
//            else
//            {
//                Console.WriteLine("Its index is {0}", answer);
//            }

//            /*Sort*/
//            int[] unsortedArray = { 4, 6, 2, 7, 5 };
//            Console.WriteLine("Sorted Array");
//            Array.Sort(unsortedArray);
//            foreach (int i in unsortedArray)
//            {
//                Console.WriteLine(i);
//            }


//            /*Reverse*/
//            Console.WriteLine("Reversed Array");
//            Array.Reverse(unsortedArray);
//            foreach (int y in unsortedArray)
//            {
//                Console.WriteLine(y);
//            }
//        }
//    }
//}

