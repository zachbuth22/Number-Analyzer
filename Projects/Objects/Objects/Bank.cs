using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lecture
{
internal class Bank
    {
        //properties
        private decimal Balance { get; set; }

        //constructor
        public Bank(decimal _balance)
        {
            Balance = _balance;
        }
        //methods
        public void Deposit(decimal cash)
        {
            Balance += cash;
        }
        public decimal Withdraw(decimal cash)
        {
            if(cash > Balance)
            {
                return 0;
            }
            else
            {
                Balance -= cash;
                return cash;
            }
 
        }
        public decimal GetBalance()
        {
            return Balance;
        }
    }
}

