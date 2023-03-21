//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace SamplePrj_CSharp
//{
//    class ExceptionHandling
//    {
//        static void Main(string[] args)
//        {
//            StreamReader streamReader = null;
//            try
//            {
//                streamReader = new StreamReader(@"D:\C#\SamplePrj_CSharp\SmpleFile.txt");
//                Console.WriteLine(streamReader.ReadToEnd());
//                streamReader.Close();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//                Console.WriteLine();
//                Console.WriteLine();
//                Console.WriteLine(ex.StackTrace);
//                throw;
//            }
//            finally
//            {
//                if (streamReader != null)
//                {
//                    streamReader.Close();
//                }
//                Console.WriteLine("Finally Block");
//            }
//        }
//    }
//}
