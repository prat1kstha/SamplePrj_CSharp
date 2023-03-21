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

//            Queue<Customer> queueCustomers = new Queue<Customer>();
//            /*Enqueue*/
//            queueCustomers.Enqueue(c1);
//            queueCustomers.Enqueue(c2);
//            queueCustomers.Enqueue(c3);
//            queueCustomers.Enqueue(c4);
//            queueCustomers.Enqueue(c5);

//            /*Peek*/
//            Customer q3 = queueCustomers.Peek();
//            Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}", q3.ID, q3.Name, q3.Gender);
//            Console.WriteLine("Queue List = " + queueCustomers.Count());

//            while (queueCustomers.Count > 0)
//            {
//                /*Dequeue*/
//                Customer q1 = queueCustomers.Dequeue();
//                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}", q1.ID, q1.Name, q1.Gender);
//                Console.WriteLine("Queue List = " + queueCustomers.Count());
//            }

//            if (queueCustomers.Contains(c2))
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

