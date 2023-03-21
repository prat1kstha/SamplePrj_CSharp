//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class OverridingToStringMethod
//    {
//        static void Main(string[] Args)
//        {
//            int num = 10;
//            Console.WriteLine(num.ToString());

//            Customer c1 = new Customer();
//            c1.FirstName = "Pratik";
//            c1.LastName = "Shrestha";
//            Console.WriteLine(c1.ToString());

//            /*ToString() vs Convert.ToString()*/
//            Customer c2 = null;

//            string str1 = Convert.ToString(c2);
//            Console.WriteLine("Empty String: {0}", str1);

//            string str2 = c2.ToString();
//            Console.WriteLine(str2);
//        }
//    }

//    public class Customer
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }

//        public override string ToString()
//        {
//            return this.FirstName + " " + this.LastName;
//        }
//    }
//}
