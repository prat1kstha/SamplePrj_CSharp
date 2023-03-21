//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Ex2
//    {
//        static void Main(string[] args)
//        {
//            /* Write a program that promts the user for an hourly pay rate. If the value entered is less than Rs. 750 or greater than Rs. 4900, display and error message, 
//             * otherwise display a message indicating that the rate is okay*/

//            Console.WriteLine("Method 1 (Using if-else)");
//            Console.WriteLine("Enter your pay rate: ");
//            double pay = Math.Round(double.Parse(Console.ReadLine()));

//            if (pay < 750 || pay > 4900)
//            {
//                Console.WriteLine("Payrate out of range.");
//            }
//            else
//            {
//                Console.WriteLine("Payrate is okay.");
//            }

//            Console.WriteLine("");
//            Console.WriteLine("Method 2 (Conditional Operator)");
//            string output = (pay < 750 || pay > 4900) ? "Payrate out of range." : "Payrate is okay.";
//            Console.WriteLine(output);


//            /* Write a program for a lawn-mowing service. The lawn-mowing season lasts 20 weeks.
//             * The weekly fee for mowing a lot under 400 sqrfeet is $25.
//             * The fee for a lot that is greater than 400 sqrfeet and under 600 sqrfeet is 35$ per week.
//             * The fee for alot that is 600 sqrfeet or over is 50$ per week.
//             * Prompt the user for the length and width of a lawn, and then display the weekly mowing fee, as well as the total fee for the 20-week season.
//             */

//            Console.WriteLine("");
//            Console.WriteLine("Length of the lawn: ");
//            double l = double.Parse(Console.ReadLine());
//            Console.WriteLine("Width of the lawn: ");
//            double b = double.Parse(Console.ReadLine());

//            if (l <= 0 || b <= 0)
//            {
//                Console.WriteLine("Invalid Input");
//                return;
//            }

//            double area = Math.Round(l * b, 2);
//            int fee;

//            if (area < 400)
//            {
//                fee = 25;
//            }
//            else if (area >= 400 && area < 600)
//            {
//                fee = 35;
//            }
//            else
//            {
//                fee = 50;
//            }

//            Console.WriteLine("Weekly fee: ${0} , Total fee: ${1}", fee, fee * 20);

//            /* Write a program that generates a random number between 1 and 10. Ask a user to guess the random number,
//             * then display the random number and a message indicating whether the user's guess was too high, too low, or correct.
//             * -------HINT-------
//             * You can create a random number that is at least min but less than max using the following statements
//             * Random randomGenerator = new Random();
//             * int randomNumber = randomGenerator.Next(min,max);
//             */
//            Random randomGenerator = new Random();
//            int randomNumber = randomGenerator.Next(1, 11);

//            Console.WriteLine("Guess a number: ");
//            int guess = int.Parse(Console.ReadLine());

//            Console.WriteLine("The random number was {0}", randomNumber);

//            if (guess < randomNumber)
//            {
//                Console.WriteLine("Your guess was lower.");
//            }
//            else if (guess == randomNumber)
//            {
//                Console.WriteLine("Your guess was correct.");
//            }
//            else
//            {
//                Console.WriteLine("Your guess was higher.");
//            }


//        }
//    }
//}
