using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class MaxPassengerCapacityException : Exception
    {
        public MaxPassengerCapacityException() : base("Passenger Capacity will exceed maximum passenger capacity") { }
    }
}