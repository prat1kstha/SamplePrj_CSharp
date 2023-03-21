//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class ClassStudent
//    {
//        private string Name;
//        private string FirstName;
//        public string LastName { get; set; }
//        private int Age;
//        private double FinalGrade;

//        public ClassStudent(string Name, int Age, double FinalGrade)
//        {
//            this.Name = Name;
//            this.Age = Age;
//            this.FinalGrade = FinalGrade;
//        }

//        /*Constructor Overloading*/
//        public ClassStudent(string Name, int Age) : this(Name, Age, 0)
//        {

//        }

//        public void SayHello()
//        {
//            Console.WriteLine("Hello {0}", Name);
//        }

//        /*Get Method*/
//        public string GetName()
//        {
//            if(Age >= 18)
//            {
//                return Name;
//            }
//            else
//            {
//                return "Information cannot be disclosed.";
//            }
//        }

//        /*Set Method*/
//        public void SetName(string newName)
//        {
//            if (newName == "")
//            {
//                Console.WriteLine("Invalid Name Character.");
//            }
//            else
//            {
//                this.Name = newName;
//            }
//        }

//        /*Property*/
//        public string name
//        {
//            get
//            {
//                if (Age >= 18)
//                {
//                    return Name;
//                }
//                else
//                {
//                    return "Information cannot be disclosed.";
//                }
//            }
//            set
//            {
//                if (value == "")
//                {
//                    Console.WriteLine("Invalid Name Character.");
//                }
//                else
//                {
//                    Name = value;
//                }
//            }
//        }

//        /*Auto-Implemented Property*/
//        public ClassStudent(string FirstName, string lastname, int Age, double FinalGrade)
//        {
//            this.FirstName = FirstName;
//            this.LastName = lastname;
//            this.Age = Age;
//            this.FinalGrade = FinalGrade;
//        }
//    }
//}
 