namespace APBD_Cw2.Exceptions;

public class RentalNotFoundException(int rentalId)
    : Exception($"error: Rental with id {rentalId} not found.");