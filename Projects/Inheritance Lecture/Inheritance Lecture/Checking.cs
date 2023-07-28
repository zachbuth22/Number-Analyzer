using System;
namespace Inheritance_Lecture
{
    public class CheckingAccount : BankAccount
    {
        //properties
 
        public decimal OverdraftFee { get; set; }

        //constructor
       
        public CheckingAccount(int _accNumber, decimal _balance, string _cName,
            string _cAddress, decimal _overdraft) :
            base(_accNumber, _balance, _cName,
                _cAddress)
        {
            OverdraftFee = _overdraft;
        }

        //methods
        //any method not overwritten can be accessed
        public override decimal Withdraw(decimal cash)
        { 
            if (cash > Balance)
            {
                Balance = Balance -= cash + OverdraftFee;
                return cash;
            }
            else
            {
                return cash;
            }  
        }
    }
}


