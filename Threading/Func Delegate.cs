//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace SamplePrj_CSharp
//{
//    class FuncDelegate
//    {
//        static void Main(string[] args)
//        {
//            List<Employee> listEmployee = new List<Employee>()
//            {
//                new Employee{ ID = 101, Name = "Mark"},
//                new Employee{ ID = 102, Name = "John"},
//                new Employee{ ID = 103, Name = "Mary"},
//            };

//            Func<Employee, string> selector = emp => "Name = " + emp.Name;
//            IEnumerable<string> names = listEmployee.Select(selector);

//            foreach (string name in names)
//            {
//                Console.WriteLine(name);
//            }

//            Func<int, int, string> funcDelegate = (firstNumber, secondNumber) => "Sum = " + (firstNumber + secondNumber).ToString();

//            string result = funcDelegate(10, 20);
//            Console.WriteLine(result);
//        }
//    }

//    public class Employee
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//    }
//}

