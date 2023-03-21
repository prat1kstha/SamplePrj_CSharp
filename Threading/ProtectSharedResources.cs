//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;
//using System.Diagnostics;

//namespace SamplePrj_CSharp
//{
//    class ProtectSharedResources
//    {
//        static int Total = 0;
//        static void Main(string[] args)
//        {
//            Stopwatch stopwatch = Stopwatch.StartNew();

//            Thread t1 = new Thread(AddOneMillion);
//            Thread t2 = new Thread(AddOneMillion);
//            Thread t3 = new Thread(AddOneMillion);

//            t1.Start(); t2.Start(); t3.Start();
//            t1.Join(); t2.Join(); t3.Join();

//            Console.WriteLine("Total = " + Total);

//            stopwatch.Stop();
//            Console.WriteLine(stopwatch.ElapsedTicks);
//        }

//        static object _lock = new object();
//        public static void AddOneMillion()
//        {
//            for (int i = 0; i < 1000000; i++)
//            {
//                /*Using Lock*/
//                lock (_lock)
//                {
//                    Total++;
//                }

//                Monitor.Enter(_lock);
//                try
//                {
//                    Total++;
//                }
//                finally
//                {
//                    Monitor.Exit(_lock);
//                }

//                /*Using Interlocked*/
//                //Interlocked.Increment(ref Total);
//            }
//        }
//    }
//}

