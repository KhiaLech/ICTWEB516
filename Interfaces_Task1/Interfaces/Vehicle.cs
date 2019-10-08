using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Vehicle
    {
        public int PassengerCapacity { get; set; }
        public int Passengers { get; set; }
        /// <summary>
        /// Weight in kilograms
        /// </summary>
        /// <value></value>
        public int Weight { get; set; }

        public Vehicle(int passengerCapacity, int passengers, int weight)
        {
            this.PassengerCapacity = passengerCapacity;
            this.Passengers = passengers;
            this.Weight = weight;
        }

        

        public void AddPassengers(int newPassengers)
        {
            if (newPassengers + Passengers <= PassengerCapacity)
            {
                Passengers += newPassengers;
                return;
            }

            throw new MaxPassengerCapacityException();
        }

        public void RemovePassengers(int outPassengers)
        {
            this.Passengers -= outPassengers;
            this.Passengers < 0 ? this.Passengers = 0 : true;
        }
    }

    public class Bus : Vehicle, IFuel, IMove, ICost
    {
        public Bus(int passengerCapacity, int passengers, int weight) : base(passengerCapacity, passengers, weight)
        {
            
        }

        public double MaxFuelCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Fuel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Odometer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddTravel(int metres)
        {
            throw new NotImplementedException();
        }

        public double CalcCost(int metres)
        {
            throw new NotImplementedException();
        }

        public double CalcFuelUsage(int distance)
        {
            throw new NotImplementedException();
        }

        public double EnergyUsed(int metres)
        {
            throw new NotImplementedException();
        }

        public void FillFuel()
        {
            throw new NotImplementedException();
        }
    }

    interface IFuel
    {
        double MaxFuelCapacity { get; set; }
        double Fuel { get; set; }

        double CalcFuelUsage(int distance);
        void FillFuel();
    }

    interface IMove
    {
        double Odometer { get; set; }

        void AddTravel(int metres);
        double EnergyUsed(int metres);
    }

    interface ICost
    {
        double CalcCost(int metres);
    }
}