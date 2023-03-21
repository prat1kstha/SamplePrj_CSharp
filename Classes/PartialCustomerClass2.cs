using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrj_CSharp
{
    partial class PartialCustomerClass
    {
        public string GetFullName()
        {
            return this._firstName + " " + this._lastName;
        }
    }
}
