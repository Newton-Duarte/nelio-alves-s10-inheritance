using System.Globalization;

var account = new BusinessAccount(
  123,
  "Newton Duarte",
  500,
  1000
);

System.Console.WriteLine("Created account");
System.Console.WriteLine(account.Balance);

System.Console.WriteLine("Withdraw: 100");
account.Withdraw(100);
System.Console.WriteLine(account.Balance.ToString("F2"), CultureInfo.InvariantCulture);

System.Console.WriteLine("Deposit: 200");
account.Deposit(200);
System.Console.WriteLine(account.Balance.ToString("F2"), CultureInfo.InvariantCulture);