//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;
//using System.Diagnostics;

//namespace SamplePrj_CSharp
//{
//    class PerformanceImplications
//    {
//        public static void Main()
//        {
//            Stopwatch stopwatch = Stopwatch.StartNew();
//            EvenNumbersSum();
//            OddNumbersSum();
//            stopwatch.Stop();
//            Console.WriteLine("Total milliseconds without multiple threads: " + stopwatch.ElapsedMilliseconds.ToString());

//            stopwatch.Start();
//            Thread t1 = new Thread(EvenNumbersSum);
//            Thread t2 = new Thread(OddNumbersSum);

//            t1.Start();
//            t2.Start();

//            t1.Join();
//            t2.Join();

//            stopwatch.Stop();
//            Console.WriteLine("Total milliseconds with multiple threads: " + stopwatch.ElapsedMilliseconds.ToString());
//        }
        
//        public static void EvenNumbersSum()
//        {
//            double sum = 0;
//            for (int i = 0; i <= 50000000; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    sum = sum + i;
//                }
//            }
//            Console.WriteLine("Even Number sum: " + sum.ToString());
//        }

//        public static void OddNumbersSum()
//        {
//            double sum = 0;
//            for (int i = 0; i <= 50000000; i++)
//            {
//                if (i % 2 == 1)
//                {
//                    sum = sum + i;
//                }
//            }
//            Console.WriteLine("Odd Number sum: " + sum.ToString());
//        }
//    }
//}

