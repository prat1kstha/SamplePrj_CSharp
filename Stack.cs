//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Queue
//    {
//        static void Main(string[] args)
//        {
//            Customer c1 = new Customer()
//            {
//                ID = 101,
//                Name = "Mark",
//                Gender = "Male"
//            };

//            Customer c2 = new Customer()
//            {
//                ID = 102,
//                Name = "Pam",
//                Gender = "Female"
//            };

//            Customer c3 = new Customer()
//            {
//                ID = 103,
//                Name = "John",
//                Gender = "Male"
//            };
//            Customer c4 = new Customer()
//            {
//                ID = 104,
//                Name = "Ken",
//                Gender = "Male"
//            };

//            Customer c5 = new Customer()
//            {
//                ID = 105,
//                Name = "Valarie",
//                Gender = "Female"
//            };

//            Stack<Customer> stackCustomers = new Stack<Customer>();
//            /*Push*/
//            stackCustomers.Push(c1);
//            stackCustomers.Push(c2);
//            stackCustomers.Push(c3);
//            stackCustomers.Push(c4);
//            stackCustomers.Push(c5);

//            /*Peek*/
//            Customer q3 = stackCustomers.Peek();
//            Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}", q3.ID, q3.Name, q3.Gender);
//            Console.WriteLine("Stack List = " + stackCustomers.Count());

//            while (stackCustomers.Count > 0)
//            {
//                /*Pop*/
//                Customer q1 = stackCustomers.Pop();
//                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}", q1.ID, q1.Name, q1.Gender);
//                Console.WriteLine("Stack List = " + stackCustomers.Count());
//            }

//            if (stackCustomers.Contains(c2))
//            {
//                Console.WriteLine("c2 exists");
//            }
//            else
//            {
//                Console.WriteLine("c2 does not exist.");
//            }
//        }
//    }

//    public class Customer
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public string Gender { get; set; }
//    }
//}

