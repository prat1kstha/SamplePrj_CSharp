//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Switch
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter year: ");
//            int year = int.Parse(Console.ReadLine());

//            switch (year)
//            {
//                case 1:
//                    {
//                        Console.WriteLine("Freshman");
//                        break;
//                    }
//                case 2:
//                    {
//                        Console.WriteLine("Sophomore");
//                        break;
//                    }
//                case 3:
//                    {
//                        Console.WriteLine("Junior");
//                        break;
//                    }
//                case 4:
//                    {
//                        Console.WriteLine("Senior");
//                        break;
//                    }
//                default:
//                    {
//                        Console.WriteLine("Invalid Year");
//                        break;
//                    }
//            }

//            float bill = 0;
//        Start:
//            Console.WriteLine("Select your coffee choice: 1 - Latte, 2 - Americano, 3 - Cappuccino");
//            int choice = int.Parse(Console.ReadLine());

//            switch (choice)
//            {
//                case 1:
//                    bill += 100;
//                    break;
//                case 2:
//                    bill += 85;
//                    break;
//                case 3:
//                    bill += 110;
//                    break;
//                default:
//                    Console.WriteLine("Invalid Selection");
//                    goto Start;
//            }

//        reorder:
//            Console.Write("Would you like to place another order? Y/N: ");
//            string reorder = Console.ReadLine();

//            switch (reorder.ToUpper())
//            {
//                case "Y":
//                    goto Start;
//                case "N":
//                    break;
//                default:
//                    Console.WriteLine("Invalid Selection");
//                    goto reorder;
//            }

//            Console.WriteLine("Your total bill amount: {0}", bill);
//        }
//    }
//}
