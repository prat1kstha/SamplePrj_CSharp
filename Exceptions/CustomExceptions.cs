//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;
//using System.Runtime.Serialization;

//namespace SamplePrj_CSharp
//{
//    class CustomExceptions
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                throw new UserAlreadyLoggedInException("User is already logged in.");
//            }
//            catch (UserAlreadyLoggedInException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }


//    [Serializable]
//    public class UserAlreadyLoggedInException : Exception
//    {
//        public UserAlreadyLoggedInException() : base()
//        {

//        }

//        public UserAlreadyLoggedInException(string message) : base(message)
//        {

//        }

//        public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
//        {

//        }

//        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
//        {

//        }
//    }
//}
