public record TransactionAll (DateTime Date, string Type, decimal Amount);
public static class Transaction
{
    public static string CreateTransferTransaction(string fromAccountId, string toAccountId, decimal amount, Currency fromCurrency, decimal convertedAmount, Currency toCurrency)
    {
        return $"[{DateTime.Now}] Перевод: {amount} {fromCurrency}; от: {fromAccountId}, кому: {toAccountId}, с конвертацией в: {convertedAmount} {toCurrency}.";
    }
}