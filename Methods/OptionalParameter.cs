//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Runtime.InteropServices;

//namespace SamplePrj_CSharp
//{
//    class OptionalParameters
//    {
//        public static void Add(int x, [Optional] int a, int y = 0, int z = 5)
//        {
//            int ans = x + y + z;
//            Console.WriteLine(ans);
//        }

//        static void Main(string[] args)
//        {
//            Add(10);
//            Add(10, 12);
//            Add(10, z: 12);
//            Add(10, a: 2);
//        }
//    }
//}
