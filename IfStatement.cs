//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class IfStatement
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the name and age of the first person.");

//            Console.Write("Name: ");
//            string name1 = Console.ReadLine();

//            Console.Write("Age: ");
//            int age1 = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter the name and age of the second person.");

//            Console.Write("Name: ");
//            string name2 = Console.ReadLine();

//            Console.Write("Age: ");
//            int age2 = int.Parse(Console.ReadLine());

//            if (age1 == age2)
//            {
//                Console.WriteLine("Both {0} and {1} are of the same age.", name1, name2);
//            }
//            else if (age1 < age2)
//            {
//                Console.WriteLine("{0} is older than {1}", name2, name1);
//            }
//            else
//            {
//                Console.WriteLine("{0} is older than {1}", name1, name2);
//            }
//        }
//    }
//}
