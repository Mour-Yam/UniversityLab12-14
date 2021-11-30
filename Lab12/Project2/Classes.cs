using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    abstract class Vehicle
    {
        protected string? vehicleNumber;
        public string? VehicleNumber { get { return vehicleNumber; }set { vehicleNumber = value; } }

        protected string? vehicleBrand;
        public string? VehicleBrand { get { return vehicleBrand; }set { vehicleBrand = value; } }

        protected string? vehicleYear;
        public string? VehicleYear { get { return vehicleYear; }set { vehicleYear = value; } }

        public Vehicle() { }
        public Vehicle(string vehicleNumber,string vehicleBrand,string vehicleYear) 
        {
            this.vehicleNumber = vehicleNumber;
            this.vehicleBrand = vehicleBrand;
            this.vehicleYear = vehicleYear;
        }


    }

    class Car : Vehicle
    {
        protected double maxSpeed;
        public double MaxSpeed { get { return maxSpeed; } set { maxSpeed = value; } }

        public Car() { }
        public Car(string vehicleNumber, string vehicleBrand, string vehicleYear,double maxSpeed)
            :base(vehicleNumber, vehicleBrand, vehicleYear)
        {
            this.maxSpeed = maxSpeed;
        }

    }

    class Bus: Vehicle
    {
        protected int sitCount;
        public int SitCount { get { return sitCount; } set { sitCount = value; } }

        public Bus() { }
        public Bus(string vehicleNumber, string vehicleBrand, string vehicleYear, int sitCount)
            : base(vehicleNumber, vehicleBrand, vehicleYear)
        {
            this.sitCount = sitCount;
        }

    }

}
