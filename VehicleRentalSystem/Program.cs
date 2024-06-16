using VehicleRentalSystem;
using VehicleRentalSystem.Interfaces;
using VehicleRentalSystem.Models;

public class Program
{
    public static void Main()
    {
        
        IVehicle myCar = new Car("Mitsubishi", "Mirage", 15000m, 3);
        IInvoice carInvoice = new Invoice(myCar, "John Doe", new DateTime(2024, 6, 3), new DateTime(2024, 6, 13), new DateTime(2024, 6, 13));
        carInvoice.PrintInvoice();

        IVehicle myMotorcycle = new Motorcycle("Triumph", "Tiger Sport 660", 10000m, 20);
        IInvoice motorcycleInvoice = new Invoice(myMotorcycle, "Mary Johnson", new DateTime(2024, 6, 3), new DateTime(2024, 6, 13), new DateTime(2024, 6, 13));
        motorcycleInvoice.PrintInvoice();

        IVehicle myCargoVan = new CargoVan("Citroen", "Jumper", 20000m, 8);
        IInvoice cargoVanInvoice = new Invoice(myCargoVan, "John Markson", new DateTime(2024, 6, 3), new DateTime(2024, 6, 18), new DateTime(2024, 6, 13));
        cargoVanInvoice.PrintInvoice();
    }
}
