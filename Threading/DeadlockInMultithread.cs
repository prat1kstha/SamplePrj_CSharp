//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace SamplePrj_CSharp
//{
//    class DeadlockInMultithread
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Main Started");
//            Account accountA = new Account(101, 5000);
//            Account accountB = new Account(102, 3000);

//            AccountManager accountManagerA = new AccountManager(accountA, accountB, 1000);
//            Thread t1 = new Thread(accountManagerA.Transfer);
//            t1.Name = "Thread1";

//            AccountManager accountManagerB = new AccountManager(accountB, accountA, 2000);
//            Thread t2 = new Thread(accountManagerB.Transfer);
//            t2.Name = "Thread2";

//            t1.Start();
//            t2.Start();

//            t1.Join();
//            t2.Join();
//            Console.WriteLine("Main Completed");
//        }
//    }

//    public class Account
//    {
//        double _balance;
//        int _id;

//        public Account(int id, double balance)
//        {
//            _id = id;
//            _balance = balance;
//        }

//        public int ID
//        {
//            get
//            {
//                return this._id;
//            }
//        }
//        public void Withdraw(double amount)
//        {
//            _balance -= amount;
//        }

//        public void Deposit(double amount)
//        {
//            _balance += amount;
//        }

//    }

//    public class AccountManager
//    {
//        Account _fromAccount;
//        Account _toAccount;
//        double _amountToTransfer;

//        public AccountManager(Account FromAccount, Account ToAccount, double AmountToTransfer)
//        {
//            _fromAccount = FromAccount;
//            _toAccount = ToAccount;
//            _amountToTransfer = AmountToTransfer;
//        }

//        public void Transfer()
//        {
//            object _lock1, _lock2;
//            if (_fromAccount.ID < _toAccount.ID)
//            {
//                _lock1 = _fromAccount;
//                _lock2 = _toAccount;
//            }
//            else
//            {
//                _lock1 = _toAccount;
//                _lock2 = _fromAccount;
//            }

//            Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire lock on " + ((Account)_lock1).ID.ToString());
//            lock (_lock1)
//            {
//                Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + ((Account)_lock1).ID.ToString());
//                Console.WriteLine("Thread suspended for 1 sec.");
//                Thread.Sleep(1000);
//                Console.WriteLine(Thread.CurrentThread.Name + " back in action and trying to acquire lock on " + ((Account)_lock2).ID.ToString());
//                lock (_lock2)
//                {
//                    Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + ((Account)_lock2).ID.ToString());
//                    _fromAccount.Withdraw(_amountToTransfer);
//                    _toAccount.Deposit(_amountToTransfer);
//                    Console.WriteLine(Thread.CurrentThread.Name + " transferred " + _amountToTransfer.ToString() + " from " + _fromAccount.ID.ToString() + " to " + _toAccount.ID.ToString());
//                }
//            }
//        }
//    }
//}

