using System.Globalization;

namespace KalkulatorRoztworu.Logic;

// Logika programu: nie wie nic o oknach i przyciskach, tylko liczy
public sealed class SolutionCalculator
{
    // Logika zna typowe naczynia. GUI tylko pokazuje tę listę
    public static IReadOnlyList<VesselPreset> TypicalVessels { get; } =
    [
        new("Kieliszek (50 ml)", 50),
        new("Szklanka (250 ml)", 250),
        new("Kubek (300 ml)", 300),
        new("Kufel (500 ml)", 500),
        new("Butelka (700 ml)", 700)
    ];

    // Logika zna typowe roztwory i ich procentową zawartość substancji
    public static IReadOnlyList<SolutionPreset> TypicalSolutions { get; } =
    [
        new("Piwo (5%)", 5),
        new("Wino (12%)", 12),
        new("Wódka (40%)", 40),
        new("Spirytus (96%)", 96),
        new("Ocet spirytusowy (10%)", 10),
        new("Woda utleniona (3%)", 3),
        new("Płyn do dezynfekcji (70%)", 70)
    ];

    // Złe dane -> ArgumentException z komunikatem, który GUI pokaże użytkownikowi
    public CalculationResult Calculate(decimal capacityMl, decimal substancePercent, int vesselCount)
    {
        if (capacityMl <= 0)
        {
            throw new ArgumentException("Pojemność naczynia musi być większa od zera.");
        }

        if (substancePercent is < 0 or > 100)
        {
            throw new ArgumentException("Zawartość substancji musi mieścić się w zakresie od 0 do 100%.");
        }

        if (vesselCount <= 0)
        {
            throw new ArgumentException("Liczba naczyń musi być większa od zera.");
        }

        var totalVolume = capacityMl * vesselCount;              // łączna objętość płynu
        var pureSubstance = totalVolume * substancePercent / 100; // objętość czystej substancji

        return new CalculationResult(totalVolume, pureSubstance);
    }

    // Wersja dla GUI: dostaje tekst prosto z pól formularza, sama zamienia go na liczby
    public CalculationResult Calculate(string capacityText, string percentText, string countText) =>
        Calculate(
            ParseDecimal(capacityText, "Pojemność naczynia"),
            ParseDecimal(percentText, "Zawartość substancji"),
            ParseCount(countText));

    // Tekst -> liczba dziesiętna. Przyjmuje i przecinek, i kropkę: "2,5" oraz "2.5"
    public static decimal ParseDecimal(string text, string fieldName)
    {
        var normalized = text.Trim().Replace(',', '.');

        if (!decimal.TryParse(normalized, NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign,
                CultureInfo.InvariantCulture, out var value))
        {
            throw new ArgumentException($"{fieldName}: wpisz liczbę, np. 50 albo 2,5.");
        }

        return value;
    }

    // Tekst -> liczba całkowita (liczba naczyń nie może być ułamkiem)
    public static int ParseCount(string text)
    {
        if (!int.TryParse(text.Trim(), out var value))
        {
            throw new ArgumentException("Liczba naczyń musi być liczbą całkowitą.");
        }

        return value;
    }
}
