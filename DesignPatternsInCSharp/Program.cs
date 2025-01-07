// // Encapsulation

// using DesignPatternsInCSharp.src.OopPrinciples.Encapsulation;

// BankAccount bankAccount = new BankAccount(100);

// System.Console.WriteLine(bankAccount.GetBalance());

// bankAccount.Deposit(50);
// System.Console.WriteLine(bankAccount.GetBalance());

// bankAccount.Withdraw(100);
// // bankAccount.Withdraw(-1000);
// System.Console.WriteLine(bankAccount.GetBalance());


// Abstraction

// Reduce complexity by hiding unnecessary details.

using DesignPatternsInCSharp.src.OopPrinciples.Abstraction;

EmailService emailService = new EmailService();
// emailService.Connect();
// emailService.Authenticate();
emailService.SendEmail();
// emailService.Disconnect();
