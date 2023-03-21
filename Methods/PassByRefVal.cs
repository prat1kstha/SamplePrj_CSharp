//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class PassByRefVal
//    {
//        public static void ExtraCredit(int grade)
//        {
//            grade += 3;
//        }

//        public static void GiveExtraCreditArray(int[] grades)
//        {
//            grades[0] += 3;
//        }

//        public static void RefExtraCredit(ref int grade)
//        {
//            grade += 3;
//        }

//        public static void OutExtraCredit(out int grade)
//        {
//            grade = 75;
//            grade += 3;
//        }

//        public static void CalcAddMul(int a, int b, out int add, out int mul)
//        {
//            add = a + b;
//            mul = a * b;
//        }

//        static void Main(string[] args)
//        {
//            //Pass by Value
//            int student1Grade = 75;
//            Console.WriteLine("Grade BEFORE Extra Credit: {0}", student1Grade);
//            ExtraCredit(student1Grade);
//            Console.WriteLine("Grade AFTER Extra Credit: {0}", student1Grade);

//            //Pass by Reference
//            int[] grade = new int[1];
//            grade[0] = 75;
//            Console.WriteLine("Grade Array BEFORE Extra Credit: {0}", grade[0]);
//            GiveExtraCreditArray(grade);
//            Console.WriteLine("Grade Array AFTER Extra Credit: {0}", grade[0]);

//            //Ref keyword
//            Console.WriteLine("(Ref) Grade BEFORE Extra Credit: {0}", student1Grade);
//            RefExtraCredit(ref student1Grade);
//            Console.WriteLine("(Ref) Grade AFTER Extra Credit: {0}", student1Grade);

//            //Out keyword
//            int student2Grade;
//            OutExtraCredit(out student2Grade);
//            Console.WriteLine("(Out) Grade AFTER Extra Credit: {0}", student2Grade);

//            int add, mul;
//            CalcAddMul(5, 10, out add, out mul);
//            Console.WriteLine("{0} , {1}", add, mul);
//        }

//    }
//}
