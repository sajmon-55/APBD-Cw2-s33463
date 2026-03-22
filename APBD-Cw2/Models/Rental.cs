namespace APBD_Cw2.Models;

public class Rental(Equipment equipment, User user, DateTime from, DateTime to)
{
    private static int _nextId = 1;

    public int Id { get; } = _nextId++;
    public Equipment Equipment { get; } = equipment;
    public User User { get; } = user;
    public DateTime From { get; } = from >= to ? throw new ArgumentException("Invalid time range") : from;
    public DateTime To { get; } = to;
    public bool isCancelled { get; private set; } = false;
    
    public void Cancel()
    {
        isCancelled = true;
    }
    
}