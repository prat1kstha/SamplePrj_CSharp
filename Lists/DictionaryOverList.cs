//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class DictionaryOverList
//    {
//        static void Main(string[] args)
//        {
//            /*Ask user input for a country code.
//             * If the input is a valid country code, 
//             * display the name of the country and its capital.
//             * Loop the program
//             */

//            Country c1 = new Country() { Code = "AUS", Name = "Australia", Capital = "Canberra" };
//            Country c2 = new Country() { Code = "IND", Name = "India", Capital = "New Delhi" };
//            Country c3 = new Country() { Code = "USA", Name = "United States", Capital = "Washington DC" };
//            Country c4 = new Country() { Code = "UK", Name = "United Kingdom", Capital = "London" };
//            Country c5 = new Country() { Code = "CAN", Name = "Canada", Capital = "Ottawa" };


//            /*Using Lists*/
//            //List<Country> listCountry = new List<Country>();
//            //listCountry.Add(c1);
//            //listCountry.Add(c2);
//            //listCountry.Add(c3);
//            //listCountry.Add(c4);
//            //listCountry.Add(c5);

//            //string choice = "";
//            //while (choice != "N")
//            //{
//            //    Console.WriteLine("Enter a Country Code, or type exit to close the program: ");
//            //    string countrycode = Console.ReadLine().ToUpper();

//            //    Country result = listCountry.Find(x => x.Code == countrycode);

//            //    if (result == null)
//            //    {
//            //        Console.WriteLine("Invalid Country Code");
//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine("Code = {0}, Name = {1}, Capital = {2}", result.Code, result.Name, result.Capital);
//            //    }

//            //    do
//            //    {
//            //        Console.WriteLine("Do you want to continue - Y/N?");
//            //        choice = Console.ReadLine().ToUpper();
//            //    } while (choice != "Y" && choice != "N");
//            //}

//            /*Using Dictionary*/
//            Dictionary<string, Country> dictCountry = new Dictionary<string, Country>();
//            dictCountry.Add(c1.Code, c1);
//            dictCountry.Add(c2.Code, c2);
//            dictCountry.Add(c3.Code, c3);
//            dictCountry.Add(c4.Code, c4);
//            dictCountry.Add(c5.Code, c5);

//            string choice = "";
//            while (choice != "N")
//            {
//                Console.WriteLine("Enter a Country Code, or type exit to close the program: ");
//                string countrycode = Console.ReadLine().ToUpper();

//                Country result = dictCountry.ContainsKey(countrycode) ? dictCountry[countrycode] : null;

//                if (result == null)
//                {
//                    Console.WriteLine("Invalid Country Code!!!");
//                }
//                else
//                {
//                    Console.WriteLine("Code = {0}, Name = {1}, Capital = {2}", result.Code, result.Name, result.Capital);
//                }

//                do
//                {
//                    Console.WriteLine("Do you want to continue - Y/N?");
//                    choice = Console.ReadLine().ToUpper();
//                } while (choice != "Y" && choice != "N");
//            }
//        }
//    }

//    public class Country
//    {
//        public string Code { get; set; }
//        public string Name { get; set; }
//        public string Capital { get; set; }
//    }
//}

