using System;
namespace Inheritance_Lecture
{
	public class BankAccount //PARENT
	{
		//properties
		public int AccountNumber { get; set; }
		public decimal Balance { get; set; }
		public string CustomerName { get; set; }
		public string CustomerAddress { get; set; }

		//constructor
		public BankAccount(int _accNumber, decimal _balance, string _cName, string _cAddress)
		{
			AccountNumber = _accNumber;
			Balance = _balance;
			CustomerName = _cName;
			CustomerAddress = _cAddress;
		}
		//methods
		//virtual methods CAN be overwritten

		public virtual void Deposit(decimal cash)
		{
			Balance += cash;
		}
        public virtual decimal Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                return 0;
            }
            else
            {
                Balance -= amount;
                return amount;
            }
        }
    }
}

