//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace SamplePrj_CSharp
//{
//    class ParamThreading
//    {
//        static void Main(string[] args)
//        {
//            /*using ThreadStart*/
//            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(Number.PrintNumbers);
//            Thread t1 = new Thread(parameterizedThreadStart);

//            t1.Start(20);
//        }
//    }

//    class Number
//    {
//        public static void PrintNumbers(object target)
//        {
//            for (int i = 1; i <= (int)target; i++)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}

