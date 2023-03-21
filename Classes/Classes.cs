//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class ClassMainProgram
//    {
//        static void Main(string[] args)
//        {
//            Customer C1 = new Customer("Pratik", "Shrestha");
//            C1.PrintFullName();

//            Customer C2 = new Customer();
//            C2.PrintFullName();
//        }
//    }

//    class Customer
//    {
//        private string _firstName;
//        private string _lastName;

//        //Constructor
//        public Customer(string FName, string LName)
//        {
//            _firstName = FName;
//            _lastName = LName;
//        }

//        /*Constructor Overload*/
//        public Customer() : this("N/A", "N/A")
//        {

//        }

//        /*Method*/
//        public void PrintFullName()
//        {
//            Console.WriteLine("Full Name = {0} {1}", _firstName, _lastName);
//        }

//        /*Destructor*/
//        ~Customer()
//        {
//        }
//    }
//}
