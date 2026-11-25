public static class CurrencyConverter
{
    private static decimal RateToRub(Currency currency) => currency switch
    {
        Currency.Usd => 100m,
        Currency.Eur => 120m,
        Currency.Rub => 1m,
        _ => throw new ArgumentException("Неизвестная валюта"),
    };

    public static decimal Convert(decimal amount, Currency fromCurrency, Currency toCurrency)
    {
        var amountInRub = amount * RateToRub(fromCurrency);
        var amountInToCurrency = amountInRub / RateToRub(toCurrency);
        return Math.Round(amountInToCurrency, 2);
    }

}