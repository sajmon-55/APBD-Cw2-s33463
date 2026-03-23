namespace APBD_Cw2.Exceptions;

public class TooManyRentsException(int userId) 
    : Exception($"There is too many rents for user {userId}.");