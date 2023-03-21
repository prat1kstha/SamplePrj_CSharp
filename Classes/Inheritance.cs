//using system;
//using system.collections.generic;
//using system.linq;
//using system.text;
//using system.threading.tasks;

//namespace sampleprj_csharp
//{
//    class inheritance
//    {
//        static void main(string[] args)
//        {
//            fulltimeemployee fte = new fulltimeemployee();
//            fte.firstname = "john";
//            fte.lastname = "wick";
//            fte.yearlysalary = 350000;
//            fte.printdata();

//            parttimeemployee pte = new parttimeemployee();
//            pte.firstname = "john";
//            pte.lastname = "legend";
//            pte.hourlyrate = 350;
//            pte.printdata();

//            employee[] employee = new employee[4];

//            employee[0] = new employee();
//            employee[1] = new parttimeemployee();
//            employee[2] = new fulltimeemployee();
//            employee[3] = new temporaryemployee();

//            foreach (employee e in employee)
//            {
//                e.printdata();
//            }
//        }
//    }

//    public class employee
//    {
//        public string firstname = "fn";
//        public string lastname = "ln";
//        public string email;

//        public virtual void printdata()
//        {
//            console.writeline("name: {0} {1}", firstname, lastname);
//        }
//    }

//    public class fulltimeemployee : employee
//    {
//        public float yearlysalary;
//        public override void printdata()
//        {
//            console.writeline("name: {0} {1} - fulltime", firstname, lastname);
//        }
//    }

//    public class parttimeemployee : employee
//    {
//        public float hourlyrate;
//        public override void printdata()
//        {
//            console.writeline("name: {0} {1} - parttime", firstname, lastname);
//        }
//    }

//    public class temporaryemployee : employee
//    {
//        public override void printdata()
//        {
//            console.writeline("name: {0} {1} - temporary", firstname, lastname);
//        }
//    }
//}