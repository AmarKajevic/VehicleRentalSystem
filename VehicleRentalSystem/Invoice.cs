using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentalSystem.Interfaces;

namespace VehicleRentalSystem
{
    public class Invoice : IInvoice
    {
        public IVehicle RentedVehicle { get; private set; }
        public int RentalDays { get; private set; }
        public int ActualDays { get; private set; }
        public string CustomerName { get; private set; }
        public DateTime ReservationStartDate { get; private set; }
        public DateTime ReservationEndDate { get; private set; }
        public DateTime ActualReturnDate { get; private set; }

        public Invoice(IVehicle rentedVehicle, string customerName, DateTime reservationStartDate, DateTime reservationEndDate, DateTime actualReturnDate)
        {
            RentedVehicle = rentedVehicle;
            CustomerName = customerName;
            ReservationStartDate = reservationStartDate;
            ReservationEndDate = reservationEndDate;
            RentalDays = (reservationEndDate - reservationStartDate).Days;
            ActualReturnDate = actualReturnDate;
            ActualDays = (actualReturnDate - reservationStartDate).Days;
        }

        public void PrintInvoice()
        {
            decimal rentalCostPerDay = RentedVehicle.GetRentalCostPerDay(ActualDays);
            decimal initialRentalCost = rentalCostPerDay * ActualDays;
            decimal initialInsuranceCostPerDay = RentedVehicle.GetInitialInsuranceCostPerDay();
            decimal insuranceDiscountPerDay = RentedVehicle.GetInsuranceDiscountPerDay();
            decimal netInsuranceCostPerDay = initialInsuranceCostPerDay + insuranceDiscountPerDay;
            decimal initialInsuranceCost = netInsuranceCostPerDay * ActualDays;

            decimal totalRentalCost = initialRentalCost;
            decimal totalInsuranceCost = initialInsuranceCost;

            if (ActualDays < RentalDays)
            {
                totalRentalCost += RentedVehicle.GetRentalCostPerDay(RentalDays - ActualDays) * (RentalDays - ActualDays) / 2;
                totalInsuranceCost += netInsuranceCostPerDay * (RentalDays - ActualDays) / 2;
            }

            Console.WriteLine($"A {RentedVehicle.GetType().Name.ToLower()} that is {RentedVehicle.GetSpecificInfo()}:");
            Console.WriteLine("XXXXXXXXXX");
            Console.WriteLine($"Date: {DateTime.Now:yyyy-MM-dd}");
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Rented Vehicle: {RentedVehicle.Brand} {RentedVehicle.Model}");
            Console.WriteLine($"Reservation start date: {ReservationStartDate:yyyy-MM-dd}");
            Console.WriteLine($"Reservation end date: {ReservationEndDate:yyyy-MM-dd}");
            Console.WriteLine($"Reserved rental days: {RentalDays} days");
            Console.WriteLine($"Actual return date: {ActualReturnDate:yyyy-MM-dd}");
            Console.WriteLine($"Actual rental days: {ActualDays} days");
            Console.WriteLine($"Rental cost per day: {rentalCostPerDay:C}");
            Console.WriteLine($"Initial insurance per day: {initialInsuranceCostPerDay:C}");
            Console.WriteLine($"Insurance discount per day: {insuranceDiscountPerDay:C}");
            Console.WriteLine($"Insurance per day: {netInsuranceCostPerDay:C}");
            if (ActualDays < RentalDays)
            {
                Console.WriteLine($"Early return discount for rent: {RentedVehicle.GetRentalCostPerDay(RentalDays - ActualDays) * (RentalDays - ActualDays) / 2:C}");
                Console.WriteLine($"Early return discount for insurance: {netInsuranceCostPerDay * (RentalDays - ActualDays) / 2:C}");
            }
            Console.WriteLine($"Total rent: {totalRentalCost:C}");
            Console.WriteLine($"Total insurance: {totalInsuranceCost:C}");
            Console.WriteLine($"Total: {totalRentalCost + totalInsuranceCost:C}");
            Console.WriteLine("XXXXXXXXXX\n");
        }
    }
}
