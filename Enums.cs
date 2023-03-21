//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Enums
//    {
//        static void Main(string[] args)
//        {
//            Customer[] customers= new Customer[3];
//            customers[0] = new Customer()
//            {
//                Name = "Mark",
//                Gender = Gender.Male
//            };

//            customers[1] = new Customer()
//            {
//                Name = "Mary",
//                Gender = Gender.Female
//            };

//            customers[2] = new Customer()
//            {
//                Name = "Sam",
//                Gender = Gender.Unknown
//            };

//            foreach (Customer customer in customers)
//            {
//                Console.WriteLine("Name = {0}, Gender = {1}", customer.Name, customer.Gender);
//            }

//            /*Enum Class*/
//            short[] Values = (short[])Enum.GetValues(typeof(Gender));
//            foreach (int value in Values)
//            {
//                Console.WriteLine(value);
//            }

//            string[] Names = Enum.GetNames(typeof(Gender));
//            foreach (string name in Names)
//            {
//                Console.WriteLine(name);
//            }
//        }
//    }
     
//    public enum Gender : short
//    {
//        Unknown = 0,
//        Male = 1,
//        Female = 2
//    }

//    public class Customer
//    {
//        public string Name { get; set; }
//        /*Gender  0 = Unknowm, 1 = Male, 2 = Female*/
//        public Gender Gender { get; set; }
//    }
//}

