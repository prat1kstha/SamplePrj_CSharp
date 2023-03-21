//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace SamplePrj_CSharp
//{
//    class ThreadJoin_ThreadIsAlive
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Main Started.");
            
//            Thread t1 = new Thread(T1Function);
//            t1.Start();

//            Thread t2 = new Thread(T2Function);
//            t2.Start();

//            t1.Join();
//            if (!t1.IsAlive)
//            {
//                Console.WriteLine("T1 is working.");
//            }
//            else
//            {
//                Console.WriteLine("T1 Function Completed");
//            }

//            t2.Join();
//            Console.WriteLine("T2 Function Completed");

//            Console.WriteLine("Main Completed");
//        }

//        public static void T1Function()
//        {
//            Console.WriteLine("T1 Function Started.");
//            Thread.Sleep(5000);
//            Console.WriteLine("T1 Function is about to return.");
//        }
//        public static void T2Function()
//        {
//            Console.WriteLine("T2 Function Started.");
//        }
//    }
//}

