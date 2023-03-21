//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Numeric_Conversions
//    {
//        static void Main(string[] args)
//        {
//            //1. Implicit cast success
//            int x = 5;
//            double y = x;
//            Console.WriteLine(y);

//            //2. Implicit cast fail
//            //double myDouble = 5.5;
//            //int myInt = myDouble;
//            //Console.WriteLine(myInt);

//            //3. Explicit cast success
//            double myDouble = 5.5;

//            int myInt = (int)myDouble;
//            int myInt2 = Convert.ToInt16(myDouble);
//            Console.WriteLine("Cast Output: {0}", myInt);
//            Console.WriteLine("Convert Output: {0}", myInt2);

//            string strNumber = "100";
//            int intNumber = int.Parse(strNumber);
//        }
//    }
//}
