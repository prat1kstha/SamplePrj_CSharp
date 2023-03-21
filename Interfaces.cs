//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Interfaces
//    {
//        public static void Main(string[] Args)
//        {
//            //Customer c1 = new Customer();
//            //c1.Print1();
//            //c1.Print2();

//            /*Explicit Interface Implementation*/
//            Program p1 = new Program();
//            ((I1)p1).IMethod();
//            ((I2)p1).IMethod();
//        }
//    }

//    class Customer : ICustomer1, ICustomer2
//    {
//        public void Print1()
//        {
//            Console.WriteLine("Print1 method from inteface ICustomer2");
//        }

//        public void Print2()
//        {
//            Console.WriteLine("Print2 method from inteface ICustomer2");
//        }
//    } 


//    interface ICustomer1
//    {
//        void Print1();
//    }

//    interface ICustomer2 : ICustomer1
//    {
//        void Print2();
//    }

//    /*Explicit Interface Implementation*/
//    class Program: I1, I2
//    {
//        void I1.IMethod()
//        {
//            Console.WriteLine("I1 Interface Method.");
//        }

//        void I2.IMethod()
//        {
//            Console.WriteLine("I2 Interface Method.");
//        }
//    }

//    interface I1
//    {
//        void IMethod();
//    }

//    interface I2
//    {
//        void IMethod();
//    }
//}

