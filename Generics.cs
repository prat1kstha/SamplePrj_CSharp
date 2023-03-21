//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Generics
//    {
//        static void Main(string[] args)
//        {
//            bool Equal = Calculator.AreEqual<string>("AB", "AB");
//            if (Equal)
//            {
//                Console.WriteLine("Equal.");
//            }
//            else
//            {
//                Console.WriteLine("Not Equal.");
//            }
//        }
//    }

//    public class Calculator
//    {
//        public static bool AreEqual<T>(T val1, T val2)
//        {
//            return val1.Equals(val2);
//        }
//    }
//}
