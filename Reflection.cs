//using System;
//using System.Reflection;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Reflection
//    {
//        public static void Main(string[] Args)
//        {
//            Type T = Type.GetType("SamplePrj_CSharp.Customer");
//            //Type T = typeof(Customer);

//            Console.WriteLine("Full Name = {0}", T.FullName);

//            PropertyInfo[] properties = T.GetProperties();
//            foreach (PropertyInfo property in properties)
//            {
//                Console.WriteLine("Properties: " + property.Name + " " + property.PropertyType.Name);
//            }

//            MethodInfo[] methods = T.GetMethods();
//            foreach (MethodInfo method in methods)
//            {
//                Console.WriteLine("Method: " + method.Name + " " + method.ReturnType.Name);
//            }

//            ConstructorInfo[] constructors = T.GetConstructors();
//            foreach (ConstructorInfo constructor in constructors)
//            {
//                Console.WriteLine("Constructor: " + constructor.ToString());
//            }
//        }
//    }
//    public class Customer
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }

//        public Customer(int ID, string Name)
//        {
//            this.Name = Name;
//            this.Id = ID;
//        }

//        public Customer()
//        {
//            this.Id = -1;
//            this.Name = string.Empty;
//        }

//        public void PrintID()
//        {
//            Console.WriteLine("ID = {0}", this.Id);
//        }
//        public void PrintName()
//        {
//            Console.WriteLine("Name = {0}", this.Name);
//        }
//    }
//}
