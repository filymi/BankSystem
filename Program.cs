using System;

var bank = new Bank();
bank.AddUser("Alice");
var found = bank.FindUser("Alice");
Console.WriteLine($"Найден пользователь: {found?.Name ?? "не найден"}");

try
{
    bank.AddUser("Alice");

} catch (Exception e)
{
    Console.WriteLine(e.Message);
}