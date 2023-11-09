namespace GuidelinesStandardDotNet.Currency.Models;

public class CurrencyValue
{
    public decimal Amount { get; private set; }
    public string Culture { get; private set; }

    public CurrencyValue(decimal amount, string culture)
    {
        Amount = amount;
        Culture = culture;
    }
}