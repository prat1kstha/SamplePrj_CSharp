//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class PartialMethods
//    {
//        static void Main(string[] args)
//        {
//            PartialSampleClass c1 = new PartialSampleClass();
//            c1.PublicMethod();
//        }
//    }
    
//    public partial class PartialSampleClass
//    {
//        partial void SamplePartialMethod();
//        public void PublicMethod()
//        {
//            Console.WriteLine("Public Method Invoked");
//            SamplePartialMethod();
//        }
//    }

//    public partial class PartialSampleClass
//    {
//        partial void SamplePartialMethod()
//        {
//            Console.WriteLine("Partial Method Invoked");
//        }
//    }
//}

