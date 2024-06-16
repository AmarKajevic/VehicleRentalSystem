using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem.Models
{
    public class CargoVan : Vehicle
    {
        public int DriverExperience { get; private set; }

        public CargoVan(string brand, string model, decimal value, int driverExperience)
            : base(brand, model, value)
        {
            DriverExperience = driverExperience;
        }

        public override decimal GetRentalCostPerDay(int days)
        {
            return days <= 7 ? 50 : 40;
        }

        public override decimal GetInitialInsuranceCostPerDay()
        {
            return 0.0003m * Value;
        }

        public override decimal GetInsuranceDiscountPerDay()
        {
            return DriverExperience > 5 ? -GetInitialInsuranceCostPerDay() * 0.15m : 0;
        }

        public override string GetSpecificInfo()
        {
            return $"valued at {Value:C}, and the driver has {DriverExperience} years of driving experience";
        }
    }
}
