namespace GuidelinesStandardDotNet.Currency.Models;

public class MonetaryAmount
{
    public decimal Amount { get; private set; }
    public string CurrencyCode { get; private set; }

    public MonetaryAmount(decimal amount, string currencyCode)
    {
        Amount = amount;
        CurrencyCode = currencyCode;
    }
}