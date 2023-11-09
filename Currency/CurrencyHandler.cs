using GuidelinesStandardDotNet.Currency.Models;

namespace GuidelinesStandardDotNet.Currency;

public class CurrencyHandler
{
    public static CurrencyValue ConvertToCurrency(decimal amount, string culture)
    {
        return new CurrencyValue(amount, culture);
    }
}