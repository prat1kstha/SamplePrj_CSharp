using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrj_CSharp
{
    class ClassTaxpayer
    {
        private string ssn { get; set; }
        private double inc { get; set; }
        private double taxOwed;

        public string Ssn
        {
            get
            {
                return ssn;
            }
            set
            {
                ssn = value;
            }
        }

        public double Inc
        {
            get
            {
                return inc;
            }
            set
            {
                inc = value;
                CalcTax();
            }
        }

        public double TaxOwed
        {
            get
            {
                return taxOwed;
            }
        }

        public void CalcTax()
        {
            taxOwed = GetTaxRate(inc) * inc / 100;
        }

        private int GetTaxRate(double inc)
        {
            if (inc <= 30000)
            {
                return 15;
            }
            else
            {
                return 28;
            }
        }

    }
}
