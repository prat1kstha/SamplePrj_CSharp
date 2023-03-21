//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SamplePrj_CSharp
//{
//    class BankAccount
//    {
//        private double balance;
//        private string member;

//        public BankAccount (double balance, string member)
//        {
//            this.balance = balance;
//            this.member = member;
//        }

//        public double Balance
//        {
//            get
//            {
//                return balance;
//            }
//        }
//        public string Member
//        {
//            get
//            {
//                return member;
//            }
//        }
            
            /*Operator Overloading*/
//        public static BankAccount operator +(BankAccount bank1, BankAccount bank2)
//        {
//            double newBalance = bank1.balance + bank2.balance;
//            string newMember = bank1.member + " + " + bank2.member;

//            BankAccount newBankAccount = new BankAccount(member: newMember, balance: newBalance);
//            return newBankAccount;
//        }

//        public static BankAccount operator +(BankAccount bank1, double balance)
//        {
//            double newBalance = bank1.balance + balance;
//            string newMember = bank1.member;

//            BankAccount newBankAccount = new BankAccount(member: newMember, balance: newBalance);
//            return newBankAccount;
//        }
//    }
//}
