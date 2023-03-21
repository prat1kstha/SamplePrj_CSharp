//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Lists_Ranges
//    {
//        static void Main(string[] args)
//        {
//            Customer c1 = new Customer();
//            c1.ID = 101;
//            c1.Name = "Mark";
//            c1.Salary = 5000;
//            c1.Type = "RetailCustomer";

//            Customer c2 = new Customer();
//            c2.ID = 102;
//            c2.Name = "Pam";
//            c2.Salary = 6500;
//            c2.Type = "RetailCustomer";

//            Customer c3 = new Customer();
//            c3.ID = 103;
//            c3.Name = "John";
//            c3.Salary = 3500;
//            c3.Type = "RetailCustomer";

//            Customer c4 = new Customer();
//            c4.ID = 104;
//            c4.Name = "Jenny";
//            c4.Salary = 7500;
//            c4.Type = "CorporateCustomer";

//            Customer c5 = new Customer();
//            c5.ID = 105;
//            c5.Name = "Sam";
//            c5.Salary = 8200;
//            c5.Type = "CorporateCustomer";

//            List<Customer> listCustomers = new List<Customer>();
//            listCustomers.Add(c1);
//            listCustomers.Add(c2);
//            listCustomers.Add(c3);

//            List<Customer> listCorporateCustomers = new List<Customer>();
//            listCorporateCustomers.Add(c4);
//            listCorporateCustomers.Add(c5);

//            /*Adding a range of List*/
//            listCustomers.AddRange(listCorporateCustomers);

//            /*Insert a range of List*/
//            listCustomers.InsertRange(0, listCorporateCustomers);

//            /*Remove a range of List*/
//            listCustomers.RemoveRange(0,2);

//            /*Remove a range of List with a certain condition*/
//            listCustomers.RemoveAll(x => x.Type == "CorporateCustomer");

//            /*Getting a range of List*/
//            List<Customer> l1 = listCustomers.GetRange(0, 2);

//            foreach (Customer cl in listCustomers)
//            {
//                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", cl.ID, cl.Name, cl.Salary, cl.Type);
//            }
//        }
//    }

//    public class Customer
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public int Salary { get; set; }
//        public string Type { get; set; }
//    }
//}

