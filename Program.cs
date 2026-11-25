Currency a = Currency.Usd;
Console.WriteLine(a);
 var date = DateTime.Now;
 var b = new Transaction(date, "Deposit", 100m);
 var c  = new Transaction(date, "Deposit", 100m);
 Console.WriteLine(b);
 Console.WriteLine(b == c);

 var d = new Account("1", Currency.Usd);
 Console.WriteLine(d.Id);
 Console.WriteLine(d.Currency);
 Console.WriteLine(d.Balance);

//  d.Deposit(100m);
//  d.Deposit(250m);
//  Console.WriteLine(d.Balance);
//  d.Deposit(-5m);
//  Console.WriteLine(d.Balance);
// d.Deposit(100m);
// d.Deposit(250m);
// foreach (var t in d.History)
// {
//     Console.WriteLine(t);
// }
d.Deposit(1000m);
d.Withdraw(300m);
foreach(var t in d.History)
{
    Console.WriteLine(t);
}
Console.WriteLine(d.Balance);