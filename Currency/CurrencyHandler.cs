using GuidelinesStandardDotNet.Currency.Models;

namespace GuidelinesStandardDotNet.Currency;

public static class CurrencyHandler
{
    public static MonetaryAmount ConvertToCurrency(decimal amount, string currencyCode)
    {
        return new MonetaryAmount(amount, currencyCode);
    }
}