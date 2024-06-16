using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem.Models
{
    public class Motorcycle : Vehicle
    {
        public int RiderAge { get; private set; }

        public Motorcycle(string brand, string model, decimal value, int riderAge)
            : base(brand, model, value)
        {
            RiderAge = riderAge;
        }

        public override decimal GetRentalCostPerDay(int days)
        {
            return days <= 7 ? 15 : 10;
        }

        public override decimal GetInitialInsuranceCostPerDay()
        {
            return 0.0002m * Value;
        }

        public override decimal GetInsuranceDiscountPerDay()
        {
            return RiderAge < 25 ? GetInitialInsuranceCostPerDay() * 0.2m : 0;
        }

        public override string GetSpecificInfo()
        {
            return $"valued at {Value:C}, and the driver is {RiderAge} years old";
        }
    }
}
