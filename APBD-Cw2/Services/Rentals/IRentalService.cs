using APBD_Cw2.Models;

namespace APBD_Cw2.Services.Rentals;

public interface IRentalService
{
    public void CreateRental(User user, Equipment equipment, DateTime from, DateTime to);
    public void ReturnEquipment(int rentalId, DateTime date);
    public void CalculatePenalty(int rentalId, DateTime date);
    public List<Rental> GetUserRentals(User user);
    public List<Rental> GetExpiredRentals();
    public void GenerateRaport();
    
}