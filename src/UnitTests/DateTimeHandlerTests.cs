using System.Globalization;
using GuidelinesStandardDotNet.DateTime;

namespace GuidelinesStandardUnitTests;

public class DateTimeHandlerTests
{
    [Fact]
    public void GetCurrentUtcDateTime_ReturnsCorrectFormat()
    {
        // Act
        string utcDateTime = DateTimeHandler.GetCurrentUtcDateTime();

        // Assert
        DateTime parsedDate;
        bool isValidFormat = DateTime.TryParseExact(
            utcDateTime, 
            "yyyy-MM-dd'T'HH:mm:ss", 
            CultureInfo.InvariantCulture, 
            DateTimeStyles.AssumeUniversal, 
            out parsedDate);

        Assert.True(isValidFormat);
    }

    [Theory]
    [InlineData("2024-01-01 12:00:00", 0, "2024-01-01T12:00:00")]
    [InlineData("2024-01-01 12:00:00", -3, "2024-01-01T15:00:00")]
    [InlineData("2024-01-01 12:00:00", 3, "2024-01-01T09:00:00")]
    public void ConvertToUtcDateTime_ReturnsCorrectUtcDateTime(string dateTime, int utcOffset, string expectedUtcDateTime)
    {
        // Arrange
        var localDateTime = DateTime.ParseExact(dateTime, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

        // Act
        string result = DateTimeHandler.ConvertToUtcDateTime(localDateTime, utcOffset);

        // Assert
        Assert.Equal(expectedUtcDateTime, result);
    }
}