using System;
namespace Inheritance_Lecture
{
	public class SavingsAccount: BankAccount 
	{
		//properties
		//all the parent's properties/methods come down as well
		public decimal InterestRate { get; set; }

		//constructor
		//also account for parent's constructor
		public SavingsAccount(int _accNumber, decimal _balance, string _cName,
			string _cAddress, decimal _interest):
			base(_accNumber, _balance, _cName,
				_cAddress)
		{
			InterestRate = _interest;
		}

        //methods
        //any method not overwritten can be accessed
        public override void Deposit(decimal cash)
        {
			//this will call the original if needed
			//base.Deposit(cash);
			Balance += cash;
			Balance = Balance * (InterestRate + 1);
        }
    }
}

