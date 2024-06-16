using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem.Models
{
    public class Car : Vehicle
    {
        public int SafetyRating { get; private set; }

        public Car(string brand, string model, decimal value, int safetyRating)
            : base(brand, model, value)
        {
            SafetyRating = safetyRating;
        }

        public override decimal GetRentalCostPerDay(int days)
        {
            return days <= 7 ? 20 : 15;
        }

        public override decimal GetInitialInsuranceCostPerDay()
        {
            return 0.0001m * Value;
        }

        public override decimal GetInsuranceDiscountPerDay()
        {
            return SafetyRating >= 4 ? -GetInitialInsuranceCostPerDay() * 0.1m : 0;
        }

        public override string GetSpecificInfo()
        {
            return $"valued at {Value:C}, and has a security rating of {SafetyRating}";
        }
    }
}
