//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace sampleprj_csharp
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

//    class ArrayOfObjects
//    {
//        static void Main(string[] args)
//        {
//            Person[] peopleArray = new Person[2];
//            peopleArray[0] = new Person(name: "Bob", age: 5);
//            peopleArray[1] = new Person(name: "Ted", age: 7);

//            for (int i = 0; i < peopleArray.Length; i++)
//            {
//                Console.WriteLine("{0}, {1}", peopleArray[i].Name, peopleArray[i].Age);
//            }
//        }
//    }
//}
