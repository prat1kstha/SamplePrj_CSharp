using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePrj_CSharp
{
    class JobClass
    {
        private string jobdesc;
        private double hours;
        private double charge;
        private double totalfee;

        public JobClass (string jobdesc, double hours, double charge)
        {
            JobDesc = jobdesc;
            Hours = hours;
            Charge = charge;
        }

        public string JobDesc
        {
            get
            {
                return jobdesc;
            }
            set
            {
                jobdesc = value;
            }
        }

        public double Hours
        {
            get
            {
                return hours;
            }
            set
            {
                hours = value;
                CalcTotalFee();
            }
        }

        public double Charge
        {
            get
            {
                return charge;
            }
            set
            {
                charge = value;
                CalcTotalFee();
            }
        }
        
        public double TotalFee
        {
            get
            {
                return totalfee;
            }
        }

        private void CalcTotalFee()
        {
            totalfee = this.hours * this.charge;
        }

        public static JobClass operator + (JobClass j1, JobClass j2)
        {
            string newJobDesc = j1.jobdesc + " and " + j2.jobdesc; 
            double newHours = j1.hours + j2.hours;
            double newCharge = (j1.charge + j2.charge)/2;

            JobClass newJob = new JobClass(newJobDesc, newHours, newCharge);
            return newJob;
        }
    }
}
