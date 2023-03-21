//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace SamplePrj_CSharp
//{
//    public delegate void SumofNumbersCallback(int SumOfNumbers);
//    class ParamThreading_TypeSafety
//    {
//        public static void PrintSum(int sum)
//        {
//            Console.WriteLine("Sum of Numbers = {0}", sum);
//        }

//        static void Main(string[] args)
//        {
//            SumofNumbersCallback callback = new SumofNumbersCallback(PrintSum);
            
//            Number n = new Number(20, callback);
//            Thread t1 = new Thread(new ThreadStart(n.PrintSumOfNumbers));

//            t1.Start();
//        }
//    }

//    class Number
//    {
//        private int _target;

//        SumofNumbersCallback _callBackMethod;
//        public Number(int target, SumofNumbersCallback callBackMethod)
//        {
//            this._target = target;
//            this._callBackMethod = callBackMethod;
//        }

//        public void PrintSumOfNumbers()
//        {
//            int sum = 0;

//            for (int i = 1; i <= _target; i++)
//            {
//                sum = sum + i;
//            }

//            if (_callBackMethod != null)
//                _callBackMethod(sum);
//        }
//    }
//}

