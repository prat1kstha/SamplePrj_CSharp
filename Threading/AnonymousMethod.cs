//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace SamplePrj_CSharp
//{
//    class AnonymousMethod
//    {
//        static void Main(string[] args)
//        {
//            List<Employee> employees = new List<Employee>()
//            {
//                new Employee{ ID = 101, Name = "Mark" },
//                new Employee{ ID = 102, Name = "John" },
//                new Employee{ ID = 103, Name = "Mary" },
//            };

//            /*Step 2 Create Instance of Predicate<Employee> delegate and pass the method name as an argument to the delegate constructor*/
//            //Predicate<Employee> employeePredicate = new Predicate<Employee>(FindEmployee);

//            /*Step 3 Pass delegate instance as the argument for Find() method*/
//            //Employee employee = employees.Find(emp => FindEmployee(emp));
            
//            /*Using anonymous method*/
//            Employee employee = employees.Find(delegate (Employee emp)
//            {
//                return emp.ID == 102;
//            });

//            Console.WriteLine("ID = {0}, Name = {1}", employee.ID, employee.Name);

//            /*Using Lambda Expressions*/
//            int EmpCount = employees.Count(x => x.Name.StartsWith("M"));
//            Console.WriteLine("Count of employees that start with M: {0}", EmpCount);
//        }

//        /*Step 1 Create a method whose signature matches with the signature of Predicate<Employee> delegate*/
//        //public static bool FindEmployee(Employee Emp)
//        //{
//        //    return Emp.ID == 102;
//        //}
//    }

//    public class Employee
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//    }
//}

