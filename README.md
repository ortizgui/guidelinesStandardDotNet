# Guidelines Standards Library for .NET

## Overview

This library is designed to provide standardized data handling for currency and datetime values across .NET applications. 
It ensures that currency data is encapsulated in a type-safe manner and that datetime values are managed in UTC (Coordinated Universal Time).

## Features

- **Currency Handling**: A `CurrencyValue` class that stores and handles currency amounts with associated currency codes.
- **DateTime Handling**: Methods to obtain the current UTC datetime and to convert any given datetime to UTC.

## Getting Started

To use this library, you will first need to include it in your .NET project. You can do this by adding a reference to 
the compiled DLL or by including the project directly if you're using a multi-project solution.

### CurrencyValue Class

The `CurrencyValue` class is a simple representation of a monetary amount with an associated currency code.

Usage:

```csharp
using GuidelinesStandardDotNet.Currency;

var monetaryAmount = CurrencyHandler.ConvertToCurrency(100.00m, "USD");
Console.WriteLine($"{monetaryAmount.Amount} {monetaryAmount.CurrencyCode}");
```

This will output:

```bash
100.00 USD
```

### DateTimeHandler Class
The DateTimeHandler class provides static methods for working with UTC datetime values.

Usage:

```csharp
using GuidelinesStandardDotNet.DateTime;

// Get current UTC datetime as a string
string currentUtcDateTime = DateTimeHandler.GetCurrentUtcDateTime();
Console.WriteLine(currentUtcDateTime);

// Convert a local datetime to UTC
var localDateTime = new System.DateTime(2023, 11, 8, 12, 0, 0);
int utcOffset = -5; // Assuming the local time is UTC-5
string utcDateTime = DateTimeHandler.ConvertToUtcDateTime(localDateTime, utcOffset);
Console.WriteLine(utcDateTime);
```