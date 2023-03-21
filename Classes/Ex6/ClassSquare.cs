using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrj_CSharp
{
    class ClassSquare
    {
        private int length;
        private int area;

        public ClassSquare(int length)
        {
            this.length = length;
            calcArea();
        }

        private void calcArea()
        {
            area = length * length;
        }

        public int Length
        {
            get
            {
                return length;
            }
        }
        public int Area
        {
            get
            {
                return area;
            }
        }
    }
}
