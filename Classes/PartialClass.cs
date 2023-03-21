//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web;


//namespace SamplePrj_CSharp
//{
//    class PartialClass
//    {
//        static void Main(string[] Args)
//        {
//            Customer c1 = new Customer();
//            c1.FirstName = "Pratik";
//            c1.LastName = "Shrestha";
//            string FullName = c1.GetFullName();
//            Console.WriteLine(FullName);

//            PartialCustomerClass c2 = new PartialCustomerClass();
//            c2.FirstName = "Pratik";
//            c2.LastName = "Shrestha";
//            string FullName2 = c1.GetFullName();
//            Console.WriteLine(FullName2);
//        }
//        public class Customer
//        {
//            private string _firstName;
//            private string _lastName;

//            public string FirstName
//            {
//                get { return _firstName; }
//                set { this._firstName = value; }
//            }
//            public string LastName
//            {
//                get { return _lastName; }
//                set { this._lastName = value; }
//            }

//            public string GetFullName()
//            {
//                return this._firstName + " " + this._lastName;
//            }
//        }
//    }
//}