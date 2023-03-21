//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace SamplePrj_CSharp
//{
//    class ParamThreading_TypeSafety
//    {
//        static void Main(string[] args)
//        {
//            Number n = new Number(20);
//            Thread t1 = new Thread(new ThreadStart(n.PrintNumbers));

//            t1.Start(20);
//        }
//    }

//    class Number
//    {
//        private int _target;
//        public Number(int target)
//        {
//            this._target = target;
//        }
//        public void PrintNumbers()
//        {
//            for (int i = 1; i <= _target; i++)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}

