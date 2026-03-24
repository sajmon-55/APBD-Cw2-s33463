namespace APBD_Cw2.Exceptions;

public class RentalNotFoundException(int rentalId)
    : Exception($"Rental with id {rentalId} not found.");