using APBD_Cw2.Enums;

namespace APBD_Cw2.Models.Users;

public class Student(string firstName, string lastName) : User (firstName, lastName, UserType.Student)
{
    
}