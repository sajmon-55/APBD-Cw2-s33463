using APBD_Cw2.Models;

namespace APBD_Cw2.Services.Rentals;

public interface IRentalService
{
    public void CreateRental(User user, Equipment equipment, DateTime from, DateTime to);
    public void CancelRental(int rentalId);
    public List<Rental> GetUserRentals(User user);
    public List<Rental> GetExpiredRentals();
    public void GenerateRaport();

}