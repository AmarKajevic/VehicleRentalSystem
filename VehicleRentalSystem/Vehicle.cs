using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentalSystem.Interfaces;

namespace VehicleRentalSystem
{
    public abstract class Vehicle : IVehicle
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public decimal Value { get; private set; }

        protected Vehicle(string brand, string model, decimal value)
        {
            Brand = brand;
            Model = model;
            Value = value;
        }

        public abstract decimal GetRentalCostPerDay(int days);
        public abstract decimal GetInitialInsuranceCostPerDay();
        public abstract decimal GetInsuranceDiscountPerDay();
        public abstract string GetSpecificInfo();
    }
}
