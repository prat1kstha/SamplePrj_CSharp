//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MO = MethodOverriding;
//using MH = MethodHiding;

//namespace SamplePrj_CSharp
//{
//    class HidingVsOverriding
//    {
//        public static void Main(string[] args)
//        {
//            MO.BaseClass mo = new MO.DerivedClass();
//            mo.Print();

//            MH.BaseClass mh = new MH.DerivedClass();
//            mh.Print();

//            MH.DerivedClass dc = new MH.DerivedClass();
//            dc.Print();
//        }
//    }
//}

//namespace MethodOverriding
//{
//    public class BaseClass
//    {
//        public virtual void Print()
//        {
//            Console.WriteLine("This is a base class print method from method overriding.");
//        }
//    }

//    public class DerivedClass : BaseClass
//    {
//        public override void Print()
//        {
//            Console.WriteLine("This is a derived class print method from method overriding.");
//        }
//    }
//}

//namespace MethodHiding
//{
//    public class BaseClass
//    {
//        public void Print()
//        {
//            Console.WriteLine("This is a base class print method from method hiding.");
//        }
//    }

//    public class DerivedClass : BaseClass
//    {
//        public new void Print()
//        {
//            Console.WriteLine("This is a derived class print method from method hiding.");
//        }
//    }
//}




