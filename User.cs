using System;

public class User
{
    public string Name { get; }
    public User(string name)
    {
        Name = name;
    }
    private readonly List<Account> _accounts = new();
    public IReadOnlyList<Account> Accounts => _accounts;

    public Account OpenAccount(string accountId, Currency currency)
    {
        var account = new Account(accountId, currency);
        _accounts.Add(account);
        return account;
    }
}