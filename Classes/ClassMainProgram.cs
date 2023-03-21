//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class ClassMainProgram
//    {
//        static void Main(string[] args)
//        {
//            /*Without Constructor*/
//            ClassStudent s1 = new ClassStudent();
//            s1.Name = "Bob";
//            s1.Age = 15;
//            s1.FinalGrade = 65;
//            s1.SayHello();

//            ClassStudent s2 = new ClassStudent();
//            s1.Name = "Frank";
//            s1.Age = 12;
//            s1.FinalGrade = 90;
//            s1.SayHello();

//            ClassStudent s3 = new ClassStudent();
//            s1.Name = "Ted";
//            s1.Age = 15;
//            s1.FinalGrade = 95;
//            s1.SayHello();

//            Console.WriteLine(s1.Name);


//            /*With Constructor*/
//            ClassStudent s1 = new ClassStudent(Name: "Bob", Age: 19, FinalGrade: 65);
//            Console.WriteLine(s1.GetName());
//            s1.SetName("");
//            s1.SayHello();


//            ClassStudent s2 = new ClassStudent(Name: "Frank", Age: 12, FinalGrade: 90);
//            s2.SayHello();
//            ClassStudent s3 = new ClassStudent(Name: "Ted", Age: 15, FinalGrade: 95);
//            s3.SayHello();
//            ClassStudent s4 = new ClassStudent(Name: "Nathan", Age: 15);
//            s4.SayHello();


//            /*With Property*/
//            Console.WriteLine(s1.name);
//            s1.name = "Norman";
//            Console.WriteLine(s1.name);

//            /*With Auto-Implemented Property*/
//            ClassStudent s5 = new ClassStudent(FirstName: "Chris", lastname: "Evans", Age: 16, FinalGrade: 78);
//            Console.WriteLine(s5.LastName);

//        }
//    }
//}
