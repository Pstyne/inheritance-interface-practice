using System;
using System.Collections.Generic;

namespace vehicles
{
  public class GasStation : Station
  {
    public override void Refuel(List<IGasVehicle> vehicles)
    {
      vehicles.ForEach(v => Console.WriteLine($"{this.ToString()}: The {v.GetType().Name} has been refueled with {v.FuelCapacity} gallons"));
    }
  }
}