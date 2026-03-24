using APBD_Cw2.Models;

namespace APBD_Cw2.Services.Rentals;

public interface IRentalService
{
    public void CreateRental(User user, Equipment equipment, DateTime from, DateTime to);
    public void CancelRental(int rentalId);
    public void CalculatePenalty(int rentalId, DateTime actualReturn);
    public List<Rental> GetUserRentals(User user);
    public List<Rental> GetExpiredRentals(DateTime actualReturn);
    public void GenerateRaport();
    
}