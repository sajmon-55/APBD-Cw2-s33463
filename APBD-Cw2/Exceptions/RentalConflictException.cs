namespace APBD_Cw2.Exceptions;

public class RentalConflictException(int equipmentId, DateTime from, DateTime to) 
    :  Exception($"error: Equipment {equipmentId} is already reserved for the period from {from} to {to}.");