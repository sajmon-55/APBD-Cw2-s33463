


using APBD_Cw2.Models;
using APBD_Cw2.Models.Equipments;
using APBD_Cw2.Models.Users;
using APBD_Cw2.Services.Equipments;
using APBD_Cw2.Services.Rentals;
using APBD_Cw2.Services.Users;

var eq1 = new Laptop("Asus", 16, "Intel");
var eq2 = new Laptop("Lenovo", 8, "Intel");
var eq3 = new Laptop("Acer", 32, "AMD");
var eq4 = new Keyboard("Ryzen", "Green", true);
var eq5 = new Mouse("Steelseries", 12000, false);

var user1 = new Student("Jan", "Nowak");
var user2 = new Student("Rafał", "Pietrzak");
var user3 = new Employee("Maria", "Nikola");
var user4 = new Employee("Stefan", "Panda");

IEquipmentService eqService = new EquipmentService();
eqService.AddEquipment(eq1);
eqService.AddEquipment(eq2);
eqService.AddEquipment(eq3);
eqService.AddEquipment(eq4);
eqService.AddEquipment(eq5);

IUserService  userService = new UserService();
userService.AddUser(user1);
userService.AddUser(user2);
userService.AddUser(user3);

IRentalService rentalService = new RentalService();

try
{
    Console.WriteLine("s: Creating I rental");
    rentalService.CreateRental(user1, eq2, new DateTime(2020, 1, 1), new DateTime(2020, 1, 12));
    Console.WriteLine("s: Rental created---");
    Console.WriteLine("s: Creating II rental -> Attempt to rent unavailable eq");
    rentalService.CreateRental(user1, eq2 ,new DateTime(2020, 1, 1), new DateTime(2020, 1, 12));
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    Console.WriteLine("s: Creating II rental -> different eq");
    rentalService.CreateRental(user1, eq4 ,new DateTime(2020, 1, 1), new DateTime(2020, 1, 12));
    Console.WriteLine("s: Rental created");
    Console.WriteLine("s: Creating III rental -> checking limit for Student");
    rentalService.CreateRental(user1, eq5 ,new DateTime(2020, 1, 1), new DateTime(2020, 1, 12));
    Console.WriteLine("s: Rental created");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    Console.WriteLine("s: Creating III rental -> different user");
    rentalService.CreateRental(user2, eq5 ,new DateTime(2020, 1, 1), new DateTime(2020, 1, 12));
    Console.WriteLine("s: Rental created");
    Console.WriteLine("s: Creating IV rental -> different user type");
    rentalService.CreateRental(user3, eq1 ,new DateTime(2020, 1, 1), new DateTime(2020, 1, 12));
    Console.WriteLine("s: Rental created");
    
    rentalService.ReturnEquipment(1, new DateTime(2020, 1, 10));
    Console.WriteLine("s: Rental with ID 1 ended");
    rentalService.ReturnEquipment(3, new DateTime(2020, 1, 17));
    Console.WriteLine("s: Rental with ID 3 ended");
    
    Console.WriteLine("s: Generating raport");
    rentalService.GenerateRaport();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


// var rental1 = new Rental(eq2, user1, new DateTime(2020, 1, 1), new DateTime(2020, 1, 12));
// var rental2 = new Rental(eq3, user1, new DateTime(2020, 1, 1), new DateTime(2020, 1, 12));
// var rental3 = new Rental(eq4, user1, new DateTime(2020, 1, 1), new DateTime(2020, 1, 12));
//
// var rental4 = new Rental(eq2, user2, new DateTime(2020, 1, 1), new DateTime(2020, 1, 15));
