// Encapsulation

using DesignPatternsInCSharp.src.OopPrinciples.Encapsulation;

BankAccount bankAccount = new BankAccount(100);

System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);
System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withdraw(100);
// bankAccount.Withdraw(-1000);
System.Console.WriteLine(bankAccount.GetBalance());