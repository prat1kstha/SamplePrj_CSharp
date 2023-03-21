//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Person 
//    {
//        private string name;
//        private int age;

//        public Person(string name, int age)
//        {
//            this.name = name;
//            this.age = age;
//        }

//        public string Name
//        {
//            get
//            {
//                return name;
//            }
//            set
//            {
//                name = value;
//            }
//        }
//        public int Age
//        {
//            get
//            {
//                return age;
//            }
//            set
//            {
//                age = value;
//            }
//        }
//    }
//    class PassingObjects
//    {
//        static void Main(string[] args)
//        {
//            Person p1 = new Person("Jesse", 20);
//            Console.WriteLine("Before: {0}, {1}", p1.Name, p1.Age);
//            ChangePerson(p1);
//            Console.WriteLine("After: {0}, {1}", p1.Name, p1.Age);
//        }

//        public static void ChangePerson (Person p1)
//        {
//            p1.Name = "Jeff";
//            p1.Age = 22;
//        }
//    }
//}
