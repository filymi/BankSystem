Currency a = Currency.Usd;
Console.WriteLine(a);
 var date = DateTime.Now;
 var b = new Transaction(date, "Deposit", 100m);
 var c  = new Transaction(date, "Deposit", 100m);
 Console.WriteLine(b);
 Console.WriteLine(b == c);