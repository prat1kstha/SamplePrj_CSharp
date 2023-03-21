//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections.ObjectModel;

//namespace SamplePrj_CSharp
//{
//    class Lists_Methods
//    {
//        static void Main(string[] args)
//        {
//            Customer c1 = new Customer();
//            c1.ID = 101;
//            c1.Name = "Mark";
//            c1.Salary = 5000;

//            Customer c2 = new Customer();
//            c2.ID = 102;
//            c2.Name = "Mam";
//            c2.Salary = 6500;

//            Customer c3 = new Customer();
//            c3.ID = 103;
//            c3.Name = "John";
//            c3.Salary = 3500;

//            List<Customer> custList = new List<Customer>(100);
//            custList.Add(c1);
//            custList.Add(c2);
//            custList.Add(c3);

//            /*Check if all objects are true of the given condition*/
//            if (custList.TrueForAll(x => x.Salary > 5000))
//            {
//                Console.WriteLine("Everyone's salary is greater than 5000");
//            }
//            else
//            {
//                Console.WriteLine("Not everyone's salary is greater than 5000");
//            }

//            /*Create a read only instance of the List*/
//            ReadOnlyCollection<Customer> readonlyCustList = custList.AsReadOnly();

//            /*Remove excess capacity of a List*/
//            Console.WriteLine("Before trimming: {0}", custList.Capacity);
//            custList.TrimExcess();
//            Console.WriteLine("After trimming: {0}", custList.Capacity);
//        }
//    }
//}

//    public class Customer
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public int Salary { get; set; }
//    }