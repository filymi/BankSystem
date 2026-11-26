using System;

var bank = new Bank();
var alice = bank.AddUser("Alice");
var rubAccount = alice.OpenAccount("1", Currency.Rub);
var usdAccount = alice.OpenAccount("2", Currency.Usd);
rubAccount.Deposit(1000m);
Bank.Transfer( rubAccount, usdAccount, 100m);
Console.WriteLine($"Баланс рублевого счета: {rubAccount.Balance} RUB");
Console.WriteLine($"Баланс долларового счета: {usdAccount.Balance} USD");