public class Account
{
    public string Id { get; }
    public Currency Currency { get; }
    public decimal Balance { get; private set; }


    public Account(string id, Currency currency)
    {
        Id = id;
        Currency = currency;

    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Введите корректную сумму");
        }
        Balance += amount;

        var transaction = new Transaction(DateTime.Now, "Deposit", amount);
        _history.Add(transaction);
    }

    public void Withdraw(decimal amount)
    {
        if (amount <=0)
        {
            throw new ArgumentException("Введите корректную сумму");
        }
        if (amount > Balance)
        {
            throw new InvalidCastException("Недостаточно средств");
        }
        Balance -= amount;
        var transaction = new Transaction(DateTime.Now, "Withdraw", amount);
        _history.Add(transaction);

        Withdrawn?.Invoke(amount);
    }

    public event Action<decimal>? Withdrawn;

    private readonly List<Transaction> _history = new();
    public IReadOnlyList<Transaction> History => _history;

    
}