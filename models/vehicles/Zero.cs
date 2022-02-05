using System;

namespace vehicles
{
  public class Zero : Vehicle, IElectricVehicle  // Electric motorcycle
  {
    public double BatteryKWh { get; set; } = 7.2;
    public double CurrentChargePercentage { get; set; } = 0;

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} {this.GetType().Name} zips by you. Yeeoowww!");
    }

    public override void Turn(string direction)
    {
      Console.WriteLine($"The {MainColor} {this.GetType().Name} stupidly turns {direction}.");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} {this.GetType().Name} squeals to a stop.");
    }
  }
}