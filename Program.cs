using System.Globalization;

var bAccount = new BusinessAccount(
  123,
  "Newton Duarte",
  500,
  1000
);

System.Console.WriteLine("Created account");
System.Console.WriteLine(bAccount.Balance);

System.Console.WriteLine("Withdraw: 100");
bAccount.Withdraw(100);
System.Console.WriteLine(bAccount.Balance.ToString("F2"), CultureInfo.InvariantCulture);

System.Console.WriteLine("Deposit: 200");
bAccount.Deposit(200);
System.Console.WriteLine(bAccount.Balance.ToString("F2"), CultureInfo.InvariantCulture);

// UPCASTING

Account acc1 = bAccount;
Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

// DOWNCASTING

BusinessAccount acc4 = (BusinessAccount)acc2;
acc4.Loan(100.0);

// BusinessAccount acc5 = (BusinessAccount)acc3;
if (acc3 is BusinessAccount) {
    //BusinessAccount acc5 = (BusinessAccount)acc3;
    BusinessAccount acc5 = acc3 as BusinessAccount;
    acc5.Loan(200.0);
    Console.WriteLine("Loan!");
}

if (acc3 is SavingsAccount) {
    //SavingsAccount acc5 = (SavingsAccount)acc3;
    SavingsAccount acc5 = acc3 as SavingsAccount;
    acc5.UpdateBalance();
    Console.WriteLine("Update!");
}