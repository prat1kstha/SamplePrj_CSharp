//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Lists
//    {
//        static void Main(string[] args)
//        {
//            Customer c1 = new Customer();
//            c1.ID = 101;
//            c1.Name = "Mark";
//            c1.Salary = 5000;

//            Customer c2 = new Customer();
//            c2.ID = 102;
//            c2.Name = "Pam";
//            c2.Salary = 6500;

//            Customer c3 = new Customer();
//            c3.ID = 103;
//            c3.Name = "John";
//            c3.Salary = 3500;

//            List<Customer> custList = new List<Customer>(2);
//            custList.Add(c1);
//            custList.Add(c2);
//            custList.Add(c3);

//            /*Using ForEach Loop*/
//            foreach (Customer cl in custList)
//            {
//                Console.WriteLine("Using ForEach Loop");
//                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cl.ID, cl.Name, cl.Salary);
//            }

//            /*Using For Loop*/
//            for (int i = 0; i < custList.Count; i++)
//            {
//                Customer c = custList[i];
//                Console.WriteLine("Using For Loop");
//                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
//            }


//            /*Insert Object into List*/
//            custList.Insert(0, c3);

//            /*Return Index Of Object*/
//            Console.WriteLine(custList.IndexOf(c3));

//            /*Check if the list contains an object*/
//            if (custList.Contains(c2))
//            {
//                Console.WriteLine("C2 exists.");
//            }
//            else
//            {
//                Console.WriteLine("C2 does not exists.");
//            }

//            /*Check if the list contains an object based on the condition*/
//            if (custList.Exists(cust => cust.Name.StartsWith("M")))
//            {
//                Console.WriteLine("Name starting the letter 'M' exists.");
//            }
//            else
//            {
//                Console.WriteLine("Name starting the letter 'M' does not exists.");
//            }

//            /*Find first matching item from the list based on the search condition*/
//            Customer cFirst = custList.Find(cust => cust.Salary >= 5000);
//            Console.WriteLine("Find Method: ID = {0}, Name = {1}, Salary = {2}", cFirst.ID, cFirst.Name, cFirst.Salary);

//            /*Find last matching item from the list based on the search condition*/
//            Customer cLast = custList.FindLast(cust => cust.Salary >= 5000);
//            Console.WriteLine("FindLast Method: ID = {0}, Name = {1}, Salary = {2}", cLast.ID, cLast.Name, cLast.Salary);

//            /*Return List of items from the list based on the search condition*/
//            Console.WriteLine("List of Customers whose Salary is greater than or equal to 5000.");
//            List<Customer> lAll = custList.FindAll(cust => cust.Salary >= 5000);
//            foreach (Customer cl in lAll)
//            {
//                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cl.ID, cl.Name, cl.Salary);
//            }

//            /*Find First Index*/
//            int FIndex = custList.FindIndex(cust => cust.Salary >= 5000);
//            Console.WriteLine("First Index = " + FIndex);

//            /*Find Last Index*/
//            int LIndex = custList.FindLastIndex(cust => cust.Salary >= 5000);
//            Console.WriteLine("Last Index = " + LIndex);


//            /*Converting Array into List*/
//            Customer[] custArray = new Customer[3];
//            custArray[0] = c1;
//            custArray[1] = c2;
//            custArray[2] = c3;

//            List<Customer> newCustList = custArray.ToList<Customer>();
//            Console.WriteLine("Converting Array into List");
//            foreach (Customer customer in newCustList)
//            {
//                Console.WriteLine("Array into List Output: ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);
//            }

//            /*Converting List to Array*/
//            Customer[] newCustArray = newCustList.ToArray();
//            for (int i = 0; i < newCustArray.Length; i++)
//            {
//                Console.WriteLine("List into Array Output: ID = {0}, Name = {1}, Salary = {2}", newCustArray[i].ID, newCustArray[i].Name, newCustArray[i].Salary);
//            }

//            Dictionary<int, Customer> newCustDict = newCustList.ToDictionary(x => x.ID);
//            foreach (KeyValuePair<int, Customer> kvp in newCustDict)
//            {
//                Customer custDict = kvp.Value;
//                Console.WriteLine("List into Dictionary Output: ID = {0}, Name = {1}, Salary = {2}", custDict.ID, custDict.Name, custDict.Salary);
//            }

//        }
//    }

//    public class Customer
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public int Salary { get; set; }
//    }
//}

