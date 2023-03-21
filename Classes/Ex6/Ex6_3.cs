//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class Ex6_1
//    {
//        static void Main(string[] args)
//        {
//            /*Design a Job class for Harold's Home Services. The class contains four data fields-Job description
//             * (for example, "wash windows"), time in hours to complete the Jon (for example, 3.5), per-hour rate
//             * charged for the Job (for example, $25.00), and total fee for the Job (hourly rate times hours). 
//             * Include properties to get and set each field except the total fee-that field will be read-only, and 
//             * its value is calculated each time either the hourly fee or the number of hours is set. Overload
//             * the + operator so that two Jobs can be added. The sum of two Jobs is a new Job containing the descriptions
//             * of both original Jobs (joined by "and"), the sum of the time in hourse for the original Jobs, and the 
//             * average of the hourly rate for the original Jobs. Write a Main() function that demonstrates all the methods
//             * work correctly
//             */

//            JobClass job1 = new JobClass(jobdesc: "wash windows", hours: 3.5, charge: 25);
//            Console.WriteLine(job1.TotalFee);

//            JobClass job2 = new JobClass(jobdesc: "clean trash", hours: 4, charge: 20);
//            Console.WriteLine(job2.TotalFee);

//            JobClass job3 = job1 + job2;
//            Console.WriteLine("New Job: {0}, New Hour: {1}, New Charge: {2}, Total Fee: {3}",job3.JobDesc, job3.Hours, job3.Charge, job3.TotalFee);

//        }
//    }
//}
