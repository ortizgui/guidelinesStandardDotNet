namespace GuidelinesStandardDotNet.DateTime;

public static class DateTimeHandler
{
    private static readonly string UtcDateTimeFormat = "yyyy-MM-dd'T'HH:mm:ss";

    public static string GetCurrentUtcDateTime()
    {
        return System.DateTime.UtcNow.ToString(UtcDateTimeFormat);
    }

    public static string ConvertToUtcDateTime(System.DateTime dateTime, int utcOffset)
    {
        // Ajusta o horário com base no offset UTC fornecido e converte para UTC
        var dateTimeOffset = new DateTimeOffset(dateTime, TimeSpan.FromHours(utcOffset));
        return dateTimeOffset.ToUniversalTime().ToString(UtcDateTimeFormat);
    }
}