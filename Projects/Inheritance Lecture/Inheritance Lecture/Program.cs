﻿//Banks
using Inheritance_Lecture;

BankAccount bank = new BankAccount(1, 1000, "Zach", "1339 Monte");
Console.WriteLine(bank.Balance);
bank.Deposit(100);
Console.WriteLine(bank.Balance);
bank.Withdraw(1500);
Console.WriteLine(bank.Balance);

SavingsAccount saving = new SavingsAccount(2, 500, "Zach", "1339 Monte Carlo", .05m);
Console.WriteLine(saving.Balance);
saving.Deposit(100);
Console.WriteLine(saving.Balance);
saving.Withdraw(1500);
Console.WriteLine(saving.Balance);

Console.WriteLine();
CheckingAccount checking = new CheckingAccount(3, 400, "Zach","1339 Monte Carlo", 50);
Console.WriteLine(checking.Balance);
checking.Deposit(100);
Console.WriteLine(checking.Balance);
checking.Withdraw(1500);
Console.WriteLine(checking.Balance);



//polymorphism
Console.WriteLine($"Acc number: {bank.AccountNumber}. Need to Audit? {Audit(bank)}");
Console.WriteLine($"Acc number: {saving.AccountNumber}. Need to Audit? {Audit(saving)}");
Console.WriteLine($"Acc number: {checking.AccountNumber}. Need to Audit? {Audit(checking)}");

static bool Audit(BankAccount acc)
{
    if(acc.Balance <0 ||acc.AccountNumber <=0)
        {
            return true;
        }
    else
        {
            return false;
        }

}









Console.ReadLine();