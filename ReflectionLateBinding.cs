//using System;
//using System.Reflection;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class ReflectionLateBinding
//    {
//        public static void Main(string[] Args)
//        {
//            /*Load the Assesmbly*/
//            Assembly exe = Assembly.GetExecutingAssembly();

//            /*Get the Type of the Class*/
//            Type customerType = exe.GetType("SamplePrj_CSharp.Customer");

//            /*Create Instance of the Class*/
//            object customerInstance = Activator.CreateInstance(customerType);

//            /*Get the Method*/
//            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

//            /*Declare Parameters in an Array*/
//            string[] parameters = new string[2];
//            parameters[0] = "Pratik";
//            parameters[1] = "Shrestha";

//            /*Invoke the Method*/
//            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);

//            Console.WriteLine(fullName);
//        }
//    }

//    public class Customer
//    {
//        public string GetFullName(string FirstName, string LastName)
//        {
//            return FirstName + " " + LastName;
//        }
//    }
//}
