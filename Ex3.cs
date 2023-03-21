//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Ex3
//    {
//        static void Main(string[] args)
//        {
//            /* Write a program that prompts the user for an hourly pay rate.
//             * While the user enters values less than $5.65 or greater than $49.99, continue to
//             * prompt the user. Before the program ends, display the valid pay rate
//             */
//            double pr;
//            do
//            {
//                Console.Write("Enter a payrate: ");
//                pr = double.Parse(Console.ReadLine());
//            } while (pr < 5.65 || pr > 49.99);

//            Console.WriteLine("The valid payrate that you entered is {0}", pr);


//            /*Wite a program that sums the integeres from 1 to 50*/

//            int i;
//            int sum = 0;
//            for (i = 1; i <= 50; i++)
//            {
//                Console.Write("{0}  ", sum);
//                sum += i;
//            }
//            Console.WriteLine();
//            Console.WriteLine("The sum of the numbers is: ", sum);


//            /*Write a program that generates a random number between 1 and 10. Ask a user
//             * to guess the random number, then display the random number and a message 
//             * indicating whether the user's guess was higher or lower, or correct
//             */
//            int min = 1;
//            int max = 11;

//            Random randomGenerator = new Random();
//            int randomNumber = randomGenerator.Next(min, max);

//            Console.Write("Enter a number between 1 to 10: ");
//            int num = int.Parse(Console.ReadLine());

//            while (num != randomNumber)
//            {
//                while (num < randomNumber)
//                {
//                    Console.Write("Your guess was lower. The number was {0}. Please try again: ", randomNumber);
//                    num = int.Parse(Console.ReadLine());
//                }
//                Console.Write("Your guess was higher. The number was {0}. Please try again: ", randomNumber);
//                num = int.Parse(Console.ReadLine());
//            }
//            Console.WriteLine("You guessed correct!");
//        }
//    }
//}
