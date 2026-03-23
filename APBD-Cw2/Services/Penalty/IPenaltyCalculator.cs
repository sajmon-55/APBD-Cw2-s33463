namespace APBD_Cw2.Services;

public interface IPenaltyCalculator
{
    public double CalculatePenalty(DateTime plannedReturn, DateTime actualReturn);
}