namespace KalkulatorRoztworu.Logic;

// Logika programu: nie wie nic o oknach i przyciskach, tylko liczy
public sealed class SolutionCalculator
{
    public CalculationResult Calculate(decimal capacityMl, decimal substancePercent, int vesselCount)
    {
        var totalVolume = capacityMl * vesselCount;              // łączna objętość płynu
        var pureSubstance = totalVolume * substancePercent / 100; // objętość czystej substancji

        return new CalculationResult(totalVolume, pureSubstance);
    }
}
