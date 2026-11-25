var Andrey = new User ("Andrey");
var rubAccount = Andrey.OpenAccount("1", Currency.Rub);
var usdAccount = Andrey.OpenAccount("2", Currency.Usd);
rubAccount.Deposit(1000m);
usdAccount.Deposit(10m);
foreach (var account in Andrey.Accounts)
{
    Console.WriteLine($"Номер: {account.Id}, Валюта: {account.Currency}, Баланс: {account.Balance}");
}