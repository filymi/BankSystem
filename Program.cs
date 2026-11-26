using System;

var bank = new Bank();
var alice = bank.AddUser("Alice");
var rubAccount = alice.OpenAccount("1", Currency.Rub);
var usdAccount = alice.OpenAccount("2", Currency.Usd);
rubAccount.Deposit(1000m);
var rubAccount2 = alice.OpenAccount("3", Currency.Rub);
Bank.Transfer(rubAccount, rubAccount2, 100m);

Console.WriteLine($"Счёт 1: {rubAccount.Balance} {rubAccount.Currency}");
Console.WriteLine($"Счёт 3: {rubAccount2.Balance} {rubAccount2.Currency}");
Console.WriteLine(rubAccount.Balance);
Console.WriteLine($"Баланс рублевого счета: {rubAccount.Balance} RUB");
Console.WriteLine($"Баланс долларового счета: {usdAccount.Balance} USD");
