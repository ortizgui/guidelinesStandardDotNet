using GuidelinesStandardDotNet.Currency.Models;

namespace GuidelinesStandardUnitTests;

public class MonetaryAmountTests
{
    [Fact]
    public void Constructor_AssignsValuesCorrectly()
    {
        // Arrange
        decimal expectedAmount = 100.5m;
        string expectedCurrencyCode = "USD";

        // Act
        MonetaryAmount monetaryAmount = new MonetaryAmount(expectedAmount, expectedCurrencyCode);

        // Assert
        Assert.Equal(expectedAmount, monetaryAmount.Amount);
        Assert.Equal(expectedCurrencyCode, monetaryAmount.CurrencyCode);
    }

    [Fact]
    public void Constructor_WithNullCurrencyCode_ThrowsArgumentException()
    {
        // Arrange
        decimal amount = 100.5m;

        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => new MonetaryAmount(amount, null));
        Assert.Equal("Currency code cannot be null or empty. (Parameter 'currencyCode')", exception.Message);
    }

    [Fact]
    public void Constructor_WithEmptyCurrencyCode_ThrowsArgumentException()
    {
        // Arrange
        decimal amount = 100.5m;

        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => new MonetaryAmount(amount, ""));
        Assert.Equal("Currency code cannot be null or empty. (Parameter 'currencyCode')", exception.Message);
    }
}