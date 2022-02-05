using System;
using System.Collections.Generic;
using System.Linq;

namespace vehicles
{
  public class Station : IRefuelStation<IGasVehicle>, IRefuelStation<IElectricVehicle>
  {
    public int Capacity { get; set; }
    public virtual void Refuel(List<IGasVehicle> vehicles)
    {
      // e.g. "The Cessna has been refueled with 200 gallons of gas"
      vehicles.ForEach(v => Console.WriteLine($"{this.GetType().Name}: The {v.MainColor} {v.GetType().Name} has been refueled with {v.FuelCapacity} gallons"));
    }

    public virtual void Refuel(List<IElectricVehicle> vehicles)
    {
      vehicles.ForEach(v => Console.WriteLine($"{this.GetType().Name}: The {v.MainColor} {v.GetType().Name} has been rechared with {v.BatteryKWh} Battery KWh"));
    }

    public override string ToString()
    {
      return String.Join("", this.GetType().Name.Select(x => Char.IsUpper(x) ? " " + x : x.ToString())).Trim();
    }
  }
}