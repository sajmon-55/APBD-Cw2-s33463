using APBD_Cw2.Enums;

namespace APBD_Cw2.Models.Users;

public class Employee(string firstName, string lastName) : User (firstName, lastName, UserType.Employee)
{
    public override int GetMaxRentals() => 2;
}