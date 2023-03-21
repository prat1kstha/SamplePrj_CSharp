//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace SamplePrj_CSharp
//{
//    class InnerExceptions
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                try
//                {
//                    Console.Write("Enter First Number: ");
//                    int FN = int.Parse(Console.ReadLine());

//                    Console.Write("Enter Second Number: ");
//                    int SN = int.Parse(Console.ReadLine());

//                    int Result = FN / SN;

//                    Console.WriteLine("Result = {0}", Result);
//                }
//                catch (Exception ex)
//                {
//                    string filePath = @"D:\C#\SamplePrj_CSharp\Logs\Lg.txt";
//                    if (File.Exists(filePath))
//                    {
//                        StreamWriter sw = new StreamWriter(filePath, true);

//                        sw.WriteLine("--------------------");
//                        sw.WriteLine(DateTime.Now);
//                        sw.WriteLine(ex.GetType().Name);
//                        sw.WriteLine(ex.Message);
//                        sw.WriteLine("--------------------");
//                        sw.Close();
//                        Console.WriteLine("An error occurred.");
//                    }
//                    else
//                    {
//                        throw new FileNotFoundException("Log File Not Found.", ex);
//                    }
//                }
//            }
//            catch (Exception exception)
//            {
//                Console.WriteLine("Current Exception: " + exception.GetType().Name);
//                if (exception.InnerException != null)
//                {
//                    Console.WriteLine("Inner Exception: " + exception.InnerException.GetType().Name);
//                }
//            }
//        }
//    }
//}
