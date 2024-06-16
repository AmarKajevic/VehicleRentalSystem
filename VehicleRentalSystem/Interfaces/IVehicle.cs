using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem.Interfaces
{
    public interface IVehicle
    {
        string Brand { get; }
        string Model { get; }
        decimal Value { get; }
        decimal GetRentalCostPerDay(int days);
        decimal GetInitialInsuranceCostPerDay();
        decimal GetInsuranceDiscountPerDay();
        string GetSpecificInfo();
    }
}
