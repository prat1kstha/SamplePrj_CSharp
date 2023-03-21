//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Ex6_1
//    {
//        static void Main(string[] args)
//        {
//            /*Create a class named TaxPayer. Data fields for Taxpayer objects include the Social Security number,
//             * The yearly gross income, and the tax owed. Include a property with get and set accessors for the first two
//             * data fields, but make the tax owed a read-only peroperty. The tax should be calculated whenever the income 
//             * is set. Assume the tax is 15% of income for incomes under $30,000 and 28% for incomes that are $30,000 
//             * or higher. Write a program that declares an array of ten Taxpayer objects. Prompt the user for data for
//             * each object and display the ten objects.
//             */

//            ClassTaxpayer[] tp = new ClassTaxpayer[2];

//            for (int i = 0; i < tp.Length; i++)
//            {
//                tp[i] = new ClassTaxpayer();

//                Console.Write("Enter Social Security Number of Emp{0}: ", i + 1);
//                tp[i].Ssn = Console.ReadLine();
//                Console.Write("Enter the yearly income of Emp{0}: ", i + 1);

//                tp[i].Inc = double.Parse(Console.ReadLine());
//                Console.WriteLine("Tax owed by Emp{1}: {0}", tp[i].TaxOwed, i + 1);
//                Console.WriteLine();
//            }
//        }
//    }
//}
