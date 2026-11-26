public class Bank
{
    private readonly List<User> _users = new();
    public IReadOnlyList<User> Users => _users;

    public User? FindUser(string name)
    {
        foreach (var user in _users)
        {
            if (user.Name == name)
            {
                return user;
            }
        }
        return null;
    }

    public User AddUser(string name)
    {
        if (FindUser(name) != null){
            throw new InvalidOperationException("Пользователь с таким именем уже существует");
        }
        
        
            var user = new User(name);
            _users.Add(user);
            Console.WriteLine($"Пользователь {name} успешно добавлен");
        
        return user;
    }

    public static void Transfer(Account fromAccount, Account toAccount, decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Введите корректную сумму.");
        }
        if (fromAccount.Balance < amount)
        {
            throw new InvalidOperationException("Недостаточно средств на счете отправителя.");
        }

        fromAccount.Withdraw(amount);
        var converted = CurrencyConverter.Convert(amount, fromAccount.Currency, toAccount.Currency);
        toAccount.Deposit(converted);
        Console.WriteLine($"Перевод {amount} {fromAccount.Currency} с аккаунта {fromAccount.Id} на аккаунт {toAccount.Id} успешно выполнен.");
        
    }


}