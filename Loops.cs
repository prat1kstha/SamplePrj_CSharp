//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Loops
//    {
//        static void Main(string[] args)
//        {
//            int i = 0;
//            Console.WriteLine("Enter the increment value: ");
//            int c = int.Parse(Console.ReadLine());

//            /*WHILE Loop*/
//            while (i < c)
//            {
//                Console.WriteLine("Output from WHILE Loop: Hello!");
//                i++;
//            }

//            /*FOR Loop*/
//            for (i = 0; i < c; i++)
//            {
//                Console.WriteLine("Output from FOR Loop: Hello!");
//            }

//            /*DO WHILE Loop*/
//            do
//            {
//                Console.WriteLine("Output from DO WHILE Loop: Hello!");
//                i++;
//            } while (i <= c);

//            /*Nested Loop*/
//            /*A multiplication table*/
//            int tablesize = 5;
//            int d;
//            for (int v = 1; v <= tablesize; v++)
//            {
//                d = 1;
//                for (int h = 1; h <= tablesize; h++)
//                {
//                    Console.Write("{0,-3}", d * v);
//                    d++;
//                }
//                Console.WriteLine();
//            }


//            /*FOREACH Loop*/
//            int[] myArray = new int[3] { 2, 4, 6 };
//            foreach (int k in myArray)
//            {
//                Console.WriteLine("Output from FOREACH Loop: {0}", k);
//            }

//            /*Prime Numbers*/
//            int i; int j; bool isPrime;
//            for (i = 2; i <= 100; i++)
//            {
//                isPrime = true;
//                for (j = 2; j < i; j++)
//                {
//                    if (i % j == 0)
//                    {
//                        isPrime = false;
//                    }
//                }
//                if (isPrime == true)
//                {
//                    Console.WriteLine(i);
//                }
//            }


//        }
//    }
//}
