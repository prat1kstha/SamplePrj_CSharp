//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Structs
//    {
//        public static void Main(string[] Args)
//        {
//            Customer c1 = new Customer(1, "Pratik");
//            c1.PrintDetails();


//            //Object Initializer Syntax
//            Customer c2 = new Customer
//            {
//                ID = 2, 
//                Name = "Shrestha"
//            };
//            c2.PrintDetails();
//        }
//    }

//    public struct Customer
//    {
//        private int _id;
//        private string _name;

//        public Customer(int Id, string Name)
//        {
//            this._id = Id;
//            this._name = Name;
//        }

//        public int ID { get => _id; set => _id = value; }
//        public string Name { get => _name; set => _name = value; }

//        public void PrintDetails()
//        {
//            Console.WriteLine("Id = {0}, Name = {1}", this._id, this._name);
//        }
//    }
//}

