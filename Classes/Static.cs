//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace sampleprj_csharp
//{
//    class Static
//    {
//        //static void Main(string[] args)
//        //{
//        //    Person p1 = new Person("Ted", 5);
//        //    Person p2 = new Person("Ashley", 7);
//        //    Console.WriteLine(Person.Count);
//        //}
//    }

//    class Person
//    {
//        private string name;
//        private int age;

//        public static int Count;

//        public Person(string name, int age)
//        {
//            this.name = name;
//            this.age = age;

//            Count++;
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
//}


//namespace InstanceAndStatic
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Circle C1 = new Circle(5);
//            float Area1 = C1.Calculator();
//            Console.WriteLine("Area of the Circle1: {0}", Area1);

//            Circle C2 = new Circle(7);
//            float Area2 = C2.Calculator();
//            Console.WriteLine("Area of the Circle2: {0}", Area2);
//        }
//    }

//    class Circle
//    {
//        /*Static Object*/
//        static float _PI = 3.141F;
//        /*Instance Object*/
//        int _Radius;

//        public Circle(int Radius)
//        {
//            _Radius = Radius;
//        }
        
//        public float Calculator()
//        {
//            return _PI * _Radius * _Radius;
//        }
//    }
//}