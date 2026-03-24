using APBD_Cw2.Enums;

namespace APBD_Cw2.Models;

public abstract class User(string firstName, string lastName, UserType userType)
{
    private static int _nextId = 1;
    
    public int Id { get; } = _nextId++;
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
    public UserType UserType { get; } = userType;

    public abstract int GetMaxRentals();
}