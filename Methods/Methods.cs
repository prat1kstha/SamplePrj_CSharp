//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Methods
//    {
//        static void Main(string[] args)
//        {
//            DisplayMsg();
//            Console.WriteLine(Add(5, 10));

//            //Methods prime = new Methods();
//            //prime.PrimeNumbers(50);

//            PrimeNumbers(50);
//        }

//        public static void DisplayMsg()
//        {
//            Console.WriteLine("Hello World!");
//        }

//        public static int Add(int x, int y)
//        {
//            int ans = x + y;
//            return ans;
//        }


//        /*Prime Numbers*/
//        public static void PrimeNumbers(int limit)
//        {
//            int i; int j; bool isPrime;
//            for (i = 2; i <= limit; i++)
//            {
//                isPrime = true;
//                for (j = 2; j < i; j++)
//                {
//                    if (i % j == 0)
//                    {
//                        isPrime = false;
//                    }
//                }
//                if (isPrime == true)
//                {
//                    Console.WriteLine(i);
//                }
//            }
//        }
//    }
//}
