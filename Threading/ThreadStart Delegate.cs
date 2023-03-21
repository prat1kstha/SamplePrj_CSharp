//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace SamplePrj_CSharp
//{
//    class Threading
//    {
//        static void Main(string[] args)
//        {
//            /*using ThreadStart*/
//            Thread t1 = new Thread(new ThreadStart(Number.PrintNumbers));

//            /*using delegate keyword*/
//            Thread t2 = new Thread(delegate () { Number.PrintNumbers(); });

//            /*using lambda expression*/
//            Thread t3 = new Thread(() => Number.PrintNumbers());

//            t1.Start();
//        }
//    }

//    class Number
//    {
//        public static void PrintNumbers()
//        {
//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}

