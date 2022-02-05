using System;
using System.Collections.Generic;

namespace vehicles
{
  public class BatteryStation : Station
  {
    public override void Refuel(List<IElectricVehicle> vehicles)
    {
      vehicles.ForEach(v => Console.WriteLine($"{this.ToString()}: The {v.GetType().Name} has been rechared to {v.BatteryKWh} Battery KWh"));
    }
  }
}