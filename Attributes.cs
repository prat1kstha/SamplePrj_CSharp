//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Attributes
//    {
//        static void Main(string[] args)
//        {
//            Calculator.Add(10,20);

//            Calculator.Add(new List<int>() { 10, 20, 40 });
//        }
//    }

//    public class Calculator
//    {
//        [Obsolete("Use Add(List<int> Numbers) Method", true)]
//        public static int Add(int FirstNumber, int SecondNumber)
//        {
//            return FirstNumber + SecondNumber;
//        }

//        public static int Add(List<int> Numbers)
//        {
//            int Sum = 0;
//            foreach (int Num in Numbers)
//            {
//                Sum = Sum + Num;
//            }
//            return Sum;
//        }
//    }
//}
