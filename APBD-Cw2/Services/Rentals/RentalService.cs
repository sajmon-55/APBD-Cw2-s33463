using APBD_Cw2.Enums;
using APBD_Cw2.Exceptions;
using APBD_Cw2.Models;

namespace APBD_Cw2.Services.Rentals;

public class RentalService : IRentalService
{
    private readonly List<Rental> _rentals = [];
    
    public void CreateRental(User user, Equipment equipment, DateTime from, DateTime to)
    {
        if (equipment.Status != EquipmentStatus.Unavailable)
            throw new EquipmentUnavailableException(equipment.Id);

        int activeUsersRentals = _rentals.Count(r => 
            r.User == user
        );
        
        if (activeUsersRentals >= user.GetMaxRentals())
            throw new TooManyRentsException(activeUsersRentals);

        bool rentalConflict = _rentals.Any(r =>
            r.Equipment == equipment
        );
        if (rentalConflict)
            throw new RentalConflictException(equipment.Id, from, to);
        
        var newRental = new Rental(equipment, user, from, to);
        _rentals.Add(newRental);
    }
    public void ReturnEquipment(int rentalId, DateTime date)
    {
        var rental = _rentals.FirstOrDefault(r => r.Id == rentalId);
        if (rental is null)
            throw new RentalNotFoundException(rentalId);
        
        rental.Equipment.Status = EquipmentStatus.Available;
        CalculatePenalty(rentalId, date);
        rental.HasEnded = true;
    }

    public void CalculatePenalty(int rentalId, DateTime date)
    {
        var rental = _rentals.FirstOrDefault(r => r.Id == rentalId);
        if (rental is null)
        {
            throw new RentalNotFoundException(rentalId);
        }

        if (date > rental.To)
        {
            var delay = (date - rental.To).Days;
            decimal penalty = (decimal)(5.5 * delay);
            rental.Penalty = penalty;
        }
        else
        {
            Console.WriteLine("---No need for penalty---");
        }
    }

    public List<Rental> GetUserRentals(User user)
    {
        return _rentals.Where(r => r.User == user).ToList();
    }

    public List<Rental> GetExpiredRentals()
    {
        return _rentals.Where(r => r.IsExpired).ToList();
    }

    public void GenerateRaport()
    {
        throw new NotImplementedException();
    }
}