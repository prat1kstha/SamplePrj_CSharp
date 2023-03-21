//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Lists_SortSimpleType
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

//            List<Customer> custList = new List<Customer>(2);
//            custList.Add(c1);
//            custList.Add(c2);
//            custList.Add(c3);

//            Console.WriteLine("Unsorted List");
//            foreach (Customer customer in custList)
//            {
//                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);
//            }

//            /*Sorted List*/
//            Console.WriteLine("Sorted by Salary List");
//            custList.Sort();
//            foreach (Customer customer in custList)
//            {
//                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);
//            }

//            /*Name Sorted List*/
//            Console.WriteLine("Sorted by Name List");
//            SortByName sortByName = new SortByName();
//            custList.Sort(sortByName);
//            foreach (Customer customer in custList)
//            {
//                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);
//            }

//            /*Sorted by using Delegate*/
//            Console.WriteLine("Sorted by ID List");
//            Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer);
//            custList.Sort(customerComparer);
//            foreach (Customer customer in custList)
//            {
//                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);
//            }

//            /*Simplified way for sorting using Lambda expression*/
//            custList.Sort((x, y) => x.ID.CompareTo(y.ID));
//        }

//        private static int CompareCustomer(Customer x, Customer y)
//        {
//            return x.ID.CompareTo(y.ID);
//        }
//    }


//    public class Customer : IComparable<Customer>
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public int Salary { get; set; }

//        public int CompareTo(Customer other)
//        {
//            //if (this.Salary > other.Salary)
//            //    return 1;
//            //else if (this.Salary < other.Salary)
//            //    return -1;
//            //else
//            //    return 0;

//            return this.Salary.CompareTo(other.Salary);
//        }
//    }

//    public class SortByName : IComparer<Customer>
//    {
//        public int Compare(Customer x, Customer y)
//        {
//            return x.Name.CompareTo(y.Name);
//        }
//    }
//}

