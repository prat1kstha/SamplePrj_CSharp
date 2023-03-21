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
//            /*Write a program for a package delivery service. The program contains an array that holds
//             * the ten zip codes to which the company delivers packages. Prompt a user to enter a zip code
//             * and display a message indicating whether the zip code is one to which the company delivers.
//             */

//            string[] zip = new string[10]
//            {
//                "02143",
//                "43215",
//                "10001",
//                "01543",
//                "10010",
//                "11554",
//                "10013",
//                "10011",
//                "30303",
//                "10003"
//            };

//            Console.Write("Enter the zip code: ");
//            string input = Console.ReadLine();

//            Array.Sort(zip);

//            if ((Array.BinarySearch(zip, input)) >= 0)
//            {
//                Console.WriteLine("The zip code is available.");
//            }
//            else
//            {
//                Console.WriteLine("The zip code is unavailable");
//            }


//            /*Write a program that allows a teacher to enter in an amount of students. For each student ask the teacher
//             * to enter in their name and final score for the class. When the teacher in done entering the data, print the
//             * highest grade in the class, and the average grade for the class.
//             */
//            Console.Write("Enter the total number of students: ");
//            int num = int.Parse(Console.ReadLine());
//            double avgscore;
//            double highscore;
//            string highscorer;

//            string[] stdname = new string[num];
//            double[] score = new double[num];

//            for (int i = 0; i < num; i++)
//            {
//                Console.Write("Name of student #{0}: ", i + 1);
//                stdname[i] = Console.ReadLine();
//                Console.Write("Score of student #{0}: ", i + 1);
//                score[i] = double.Parse(Console.ReadLine());
//            }

//            Console.WriteLine();
//            Console.WriteLine("Score Sheet");
//            for (int x = 0; x < num; x++)
//            {
//                Console.Write(stdname[x] + " - ");
//                Console.Write(score[x]);
//                Console.WriteLine();
//            }

//            Console.WriteLine();
//            highscore = Math.Round(score.Max(), 2);
//            avgscore = Math.Round(score.Average(), 2);
//            highscorer = stdname[Array.IndexOf(score, highscore)];


//            Console.WriteLine("Highest Score in the class is {0} by {1}", highscore, highscorer);
//            Console.WriteLine("Average Score in the class is {0}", avgscore);

//            /*Create a game similar to Hangmane, in which a player guesses the letters to try to replicate
//             * a hidden word. Store at least eight words in a array, and randomly select one to be the hidden
//             * word.
//             * Initially, display the hidden word using asterisks to represent each letter. Allow the user to guess letters
//             * to replace the asterisks in the hidden word until the user completes the entire word. If the user guesses a letter
//             * that is not in the hidden word, display an appropriate message. If the user guesses a letetr that appears multiple times
//             * in the hidden word, make sure that each correct letter is placed.
//             * 
//             * ---HINT---
//             * You will need to know about strings internal array
//             * strings Contains method
//             * strings Remove method
//             * strings Insert method
//             * strings Length property
//             */

//            string[] word = { "cotiviti", "leapfrog", "deerhold", "infodevelopers", "deerwalk", "pumori", "uranustech", "synergy" };
//            Random randomnumbergenerator = new Random();
//            int randomnum = randomnumbergenerator.Next(0, 8);
//            int trycnt = 10;

//            string selectword = word[randomnum];
//            string hiddenword = string.Concat(Enumerable.Repeat("*", selectword.Length));

//            char guess;

//            Console.WriteLine("Category: Software Company");

//            while (hiddenword.Contains("*") && trycnt > 0)
//            {
//                Console.WriteLine(hiddenword);
//                Console.Write("Enter a Character: ");
//                guess = Convert.ToChar(Console.ReadLine());
//                bool containsletter = false;

//                for (int i = 0; i < selectword.Length; i++)
//                {
//                    if (selectword[i] == guess)
//                    {
//                        hiddenword = hiddenword.Remove(i, 1);
//                        hiddenword = hiddenword.Insert(i, guess.ToString());
//                        containsletter = true;
//                    }
//                }
//                if (containsletter != true)
//                {
//                    trycnt--;
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.WriteLine("Oops! Remaining tries: {0}", trycnt);
//                }
//                else
//                {
//                    Console.ForegroundColor = ConsoleColor.Green;
//                    Console.WriteLine("Great!");
//                }
//                Console.ResetColor();
//            }
//            if (trycnt == 0)
//            {
//                Console.WriteLine("Sorry, You're out of tries!! The word was {0}", selectword);
//            }
//            else
//            {
//                Console.WriteLine("Congratulations!! The word was {0}", selectword);
//            }
//        }
//    }
//}

