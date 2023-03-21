//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class MultiDimensionalArray
//    {
//        static void Main(string[] args)
//        {
//            /*Creating and assigning values to multi-dimensional array*/
//            int[,] myArray = new int[3, 4];
//            myArray[0, 0] = 1;
//            myArray[0, 1] = 2;
//            myArray[0, 2] = 3;
//            myArray[0, 3] = 4;

//            myArray[1, 0] = 5;
//            myArray[1, 1] = 6;
//            myArray[1, 2] = 7;
//            myArray[1, 3] = 8;

//            myArray[2, 0] = 9;
//            myArray[2, 1] = 0;
//            myArray[2, 2] = 1;
//            myArray[2, 3] = 2;

//            /*Another way to assign values to multi-dimensional array*/
//            int[,] myArray2 = { {1, 2, 3, 4},
//                                {5, 6, 7, 8},
//                                {9, 0, 1, 2}
//                                };

//            /*Looping on multi-dimensional array*/
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < 4; j++)
//                {
//                    Console.Write(myArray[i, j]);
//                }
//                Console.WriteLine();
//            }

//            /*Creating a jagged array*/
//            int[][] myArray3 = new int[3][];
//            myArray3[0] = new int[4] { 1, 2, 3, 4 };
//            myArray3[1] = new int[6] { 1, 2, 3, 4, 5, 6 };
//            myArray3[2] = new int[3] { 1, 2, 3 };


//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < myArray3[i].Length; j++)
//                {
//                    Console.Write(myArray3[i][j]);
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}

