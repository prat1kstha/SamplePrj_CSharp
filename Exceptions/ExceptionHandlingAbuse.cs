//using System;

//namespace SamplePrj_CSharp
//{
//    class ExceptionHandlingAbuse
//    {
//        static void Main(string[] args)
//        {
//            /*Exception Handling Abuse*/
//            try
//            {
//                Console.WriteLine("Please enter Numerator");
//                int Numerator = Convert.ToInt32(Console.ReadLine());

//                Console.WriteLine("Please enter Denominator");
//                int Denominator = Convert.ToInt32(Console.ReadLine());

//                int Result = Numerator / Denominator;

//                Console.WriteLine("Result = {0}", Result);
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Please enter a numeric value");
//            }
//            catch (OverflowException)
//            {
//                Console.WriteLine("Please enter a numeric value betweem {0} and {1}", Int32.MinValue, Int32.MaxValue);
//            }
//            catch (DivideByZeroException)
//            {
//                Console.WriteLine("Denominator cannot be 0.");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }

//            /*Proper Exception Handling*/
//            try
//            {
//                Console.WriteLine("Please enter Numerator");
//                int Numerator;
//                bool IsNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Numerator);

//                if (IsNumeratorConversionSuccessful)
//                {
//                    Console.WriteLine("Please enter Denominator");
//                    int Denominator;
//                    bool IsDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Denominator);

//                    if (IsDenominatorConversionSuccessful && Denominator != 0)
//                    {
//                        int Result = Numerator / Denominator;
//                        Console.WriteLine("Result = {0}", Result);
//                    }
//                    else
//                    {
//                        if (Denominator == 0)
//                        {
//                            Console.WriteLine("Denominator cannot be zero");
//                        }
//                        else
//                        {
//                            Console.WriteLine("Denominator should be valid number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
//                        }
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Numerator should be valid number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }
//}
