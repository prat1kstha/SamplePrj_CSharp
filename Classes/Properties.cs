//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Properties
//    {
//        public static void Main(string[] args)
//        {
//            BadStudentClass s1 = new BadStudentClass();
//            s1.ID = -10;
//            s1.Name = null;
//            s1.PassMark = -100;

//            Console.WriteLine("BadClass: ID = {0}, Name = {1}, PassMark = {2}", s1.ID, s1.Name, s1.PassMark);

//            GoodStudentClass s2 = new GoodStudentClass();
//            s2.ID = 10;
//            s2.Name ="Pratik Shrestha";

//            Console.WriteLine("GoodClass: ID = {0}, Name = {1}, PassMark = {2}", s2.ID, s2.Name, s2.PassMark);
//        }
//    }

//    public class BadStudentClass
//    {
//        public int ID;
//        public string Name;
//        public int PassMark;
//    }

//    public class GoodStudentClass
//    {
//        private int _ID;
//        private string _Name;
//        private int _PassMark = 35;

//        public int ID
//        {
//            get
//            {
//                return this._ID;
//            }
//            set
//            {
//                if (value <= 0)
//                {
//                    throw new Exception("ID cannot be a negative number.");
//                }
//                this._ID = value;
//            }
//        }

//        public string Name
//        {
//            get
//            {
//                return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
//            }
//            set
//            {
//                if (string.IsNullOrEmpty(value))
//                {
//                    throw new Exception("Name cannot be NULL or empty.");
//                }
//                this._Name = value;
//            }
            
//        }

//        public int PassMark
//        {
//            get
//            {
//                return this._PassMark;
//            }
//        }

//        public string Email { get; set; }
//        public string City { get; set; }
//    }
//}
