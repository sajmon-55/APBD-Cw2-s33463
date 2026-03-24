using APBD_Cw2.Enums;
using APBD_Cw2.Exceptions;
using APBD_Cw2.Models;

namespace APBD_Cw2.Services.Rentals;

public class RentalService : IRentalService
{
    private readonly List<Rental> _rentals = [];
    
    public void CreateRental(User user, Equipment equipment, DateTime from, DateTime to)
    {
        if (equipment.Status != EquipmentStatus.Available)
            throw new EquipmentUnavailableException(equipment.Id);

        int activeUsersRentals = _rentals.Count(r => 
            !r.isCancelled && r.User == user
        );
        
        if (activeUsersRentals >= user.GetMaxRentals())
            throw new TooManyRentsException(activeUsersRentals);

        bool rentalConflict = _rentals.Any(r =>
            !r.isCancelled && r.Equipment == equipment
        );
        if (rentalConflict)
            throw new RentalConflictException(equipment.Id, from, to);
        
        var newRental = new Rental(equipment, user, from, to);
        _rentals.Add(newRental);
    }

    public void CancelRental(int rentalId)
    {
        var rental = _rentals.FirstOrDefault(r => r.Id == rentalId);

        if (rental is null)
        {
            throw new RentalNotFoundException(rentalId);
        }
        rental.Cancel();
    }

    public void CalculatePenalty(int rentalId, DateTime actualReturn)
    {
        var rental = _rentals.FirstOrDefault(r => r.Id == rentalId);
        if (rental is null)
        {
            throw new RentalNotFoundException(rentalId);
        }

        if (actualReturn > rental.To)
        {
            var delay = (actualReturn - rental.To).Days;
            double penalty = 5.5 * delay;
            rental.SetPenalty(penalty);
        }
        else
        {
            Console.WriteLine("---No need for penalty---");
        }
    }

    public List<Rental> GetUserRentals(User user)
    {
        return _rentals.Where(r => r.User == user && !r.isCancelled).ToList();
    }

    public List<Rental> GetExpiredRentals(DateTime actualReturn)
    {
        return _rentals.Where(r => r.To > actualReturn).ToList();
    }

    public void GenerateRaport()
    {
        throw new NotImplementedException();
    }
}