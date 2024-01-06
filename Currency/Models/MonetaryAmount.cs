namespace GuidelinesStandardDotNet.Currency.Models
{
    public class MonetaryAmount
    {
        public decimal Amount { get; private set; }
        public string CurrencyCode { get; private set; }

        public MonetaryAmount(decimal amount, string currencyCode)
        {
            if (string.IsNullOrWhiteSpace(currencyCode))
                throw new ArgumentException("Currency code cannot be null or empty", nameof(currencyCode));

            Amount = amount;
            CurrencyCode = currencyCode;
        }
    }
}