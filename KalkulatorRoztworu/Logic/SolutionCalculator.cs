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
}
