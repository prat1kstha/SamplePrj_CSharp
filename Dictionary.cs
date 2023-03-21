//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Dictionary
//    {
//        static void Main(string[] args)
//        {
//            Customer c1 = new Customer()
//            {
//                ID = 101,
//                Name = "Mark",
//                Salary = 5000
//            };

//            Customer c2 = new Customer()
//            {
//                ID = 102,
//                Name = "Pam",
//                Salary = 6500
//            };

//            Customer c3 = new Customer()
//            {
//                ID = 103,
//                Name = "John",
//                Salary = 3500
//            };

//            Dictionary<int, Customer> dictCustomers = new Dictionary<int, Customer>();
//            dictCustomers.Add(c1.ID, c1);
//            dictCustomers.Add(c2.ID, c2);
//            dictCustomers.Add(c3.ID, c3);


//            /*Iterate through the key values*/
//            //foreach (KeyValuePair<int, Customer> CustKeyValuePair in dictCustomers)
//            //{
//            //    Console.WriteLine("Key = {0}", CustKeyValuePair.Key);
//            //    Customer c = CustKeyValuePair.Value;
//            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
//            //}


//            /*TryGetValue*/
//            Customer cust;
//            if (dictCustomers.TryGetValue(101, out cust))
//            {
//                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
//            }
//            else
//            {
//                Console.WriteLine("Key not found.");
//            }

//            /*Count Method*/
//            Console.WriteLine("Total Items = {0}", dictCustomers.Count(kvp => kvp.Value.Salary > 4000));

//            /*Remove a key from Dictionary*/
//            dictCustomers.Remove(101);

//            /*Remove all values from Dictionary*/
//            dictCustomers.Clear();

//            /*Converting Array into a Dictionary*/
//            Customer[] customerArray = new Customer[3];
//            customerArray[0] = c1;
//            customerArray[1] = c2;
//            customerArray[2] = c3;

//            Dictionary<int, Customer> dictArray = customerArray.ToDictionary(cust => cust.ID, cust => cust);
//            Console.WriteLine("Conversion from Array to Dictionary");
//            foreach (KeyValuePair<int, Customer> kvp in dictArray)
//            {
//                Console.WriteLine("Key = {0}", kvp.Key);
//                Customer custA = kvp.Value;
//                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", custA.ID, custA.Name, custA.Salary);
//            }


//            /*Converting List into a Dictionary*/
//            List<Customer> custL = new List<Customer>();
//            custL.Add (c1);
//            custL.Add (c2);
//            custL.Add (c3);

//            Dictionary<int, Customer> dictList = custL.ToDictionary(cust => cust.ID, cust => cust);
//            Console.WriteLine("Conversion from List to Dictionary");
//            foreach (KeyValuePair<int, Customer> kvp in dictList)
//            {
//                Console.WriteLine("Key = {0}", kvp.Key);
//                Customer cust1 = kvp.Value;
//                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust1.ID, cust1.Name, cust1.Salary);
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
