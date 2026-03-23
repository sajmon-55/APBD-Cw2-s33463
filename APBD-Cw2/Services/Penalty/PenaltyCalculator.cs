namespace APBD_Cw2.Services;

public class PenaltyCalculator : IPenaltyCalculator
{
    private const double dailyRate = 5.50;
    
    public double CalculatePenalty(DateTime plannedReturn, DateTime actualReturn)
    {
        if (actualReturn <= plannedReturn) return 0;
        var delay = (actualReturn - plannedReturn).Days;
        return dailyRate * delay;
    }
}