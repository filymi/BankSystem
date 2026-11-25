class Account
{
    public string Id { get; }
    public Currency Currency { get; }
    public decimal Balance { get; private set; }


    public Account(string id, Currency currency)
    {
        Id = id;
        Currency = currency;

    }


}