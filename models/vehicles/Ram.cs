using System;

namespace vehicles
{
  public class Ram : Vehicle, IGasVehicle  // Gas powered truck
  {
    public double FuelCapacity { get; set; } = 26;
    public double CurrentTankPercentage { get; set; }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} {this.GetType().Name} growls by you. Rrrrrummmblleee!");
    }

    public override void Turn(string direction)
    {
      Console.WriteLine($"The {MainColor} {this.GetType().Name} half-donut turns {direction}.");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} {this.GetType().Name} takes forever to stop.");
    }
  }
}