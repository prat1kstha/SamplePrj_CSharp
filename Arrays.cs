//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Arrays
//    {
//        static void Main(string[] args)
//        {
//            /*Creating and assigning values in an Array*/
//            int[] myArray = new int[5];
//            myArray[0] = 2;
//            myArray[1] = 4;
//            myArray[2] = 6;
//            myArray[3] = 8;
//            myArray[4] = 10;

//            Console.WriteLine(myArray[2]);

//            /*Other ways to assign values to an Array*/
//            int[] myArray2 = new int[3] { 1, 3, 5 };
//            int[] myArray3 = new int[] { 1, 3, 5 };
//            int[] myArray4 = { 1, 3, 5 };

//            /*Looping with Arrays*/
//            int[] grades = { 66, 70, 88, 49, 87, 75, 90 };

//            for (int i = 0; i < grades.Length; i++)
//            {
//                grades[i] += 3;
//                Console.WriteLine(grades[i]);
//            }


//            /*Using Foreach*/
//            foreach (int score in grades)
//            {
//                Console.WriteLine(score);
//            }


//            /*Check if an array contains a given input*/
//            string[] students = { "Bob", "Ted", "Tom", "Fred" };
//            int[] grades = { 77, 80, 34, 50 };

//            Console.Write("Enter student's name to search: ");
//            string stdname = Console.ReadLine();

//            int rollnum;
//            int score;
//            rollnum = Array.IndexOf(students, stdname);
//            if (rollnum >= 0)
//            {
//                score = grades[rollnum];
//                Console.WriteLine("Name: {0}, Index No. {1}, Marks Obtained: {2}", stdname, rollnum, score);
//            }
//            else
//            {
//                Console.WriteLine("Student record not found!");
//            }
//        }
//    }
//}

