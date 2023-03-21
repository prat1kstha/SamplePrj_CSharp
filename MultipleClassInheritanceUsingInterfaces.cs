//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace sampleprj_csharp
//{
//    class MultipleClassInheritanceUsingInterfaces
//    {
//        static void Main(string[] args)
//        {
//            AB ab = new AB();
//            ab.PrintA();
//            ab.PrintB();
//        }
//    }

//    interface IA
//    {
//        void PrintA();
//    }

//    interface IB
//    {
//        void PrintB();
//    }

//    class A : IA
//    {
//        public void PrintA()
//        {
//            Console.WriteLine("A Implementation");
//        }
//    }

//    class B : IB
//    {
//        public void PrintB()
//        {
//            Console.WriteLine("B Implementation");
//        }
//    }

//    class AB : IA, IB
//    {
//        A a = new A();
//        public void PrintA()
//        {
//            a.PrintA();
//        }

//        B b = new B();
//        public void PrintB()
//        {
//            b.PrintB();
//        }
//    }
//}