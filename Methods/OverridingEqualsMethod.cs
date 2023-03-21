//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class OverridingEqualsMethod
//    {
//        static void Main(string[] Args)
//        {
//            Customer c1 = new Customer();
//            c1.FirstName = "Pratik";
//            c1.LastName = "Shrestha";

//            Customer c2 = new Customer();
//            c2.FirstName = "Pratik";
//            c2.LastName = "Shrestha";

//            Console.WriteLine(c1 == c2);
//            Console.WriteLine(c1.Equals(c2));
//        }
//    }

//    public class Customer
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }

//        public override bool Equals(object obj)
//        {
//            if (obj == null)
//            {
//                return false;
//            }
            
//            if (!(obj is Customer))
//            {
//                return false;
//            }

//            return this.FirstName == ((Customer)obj).FirstName &&
//                this.LastName == ((Customer)obj).LastName;
//        }

//        public override int GetHashCode()
//        {
//            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
//        }
//    }    
//}