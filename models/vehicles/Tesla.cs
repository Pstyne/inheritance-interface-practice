using System;

namespace vehicles
{
  public class Tesla : Vehicle, IElectricVehicle  // Electric car
  {
    public double BatteryKWh { get; set; } = 75;
    public double CurrentChargePercentage { get; set; } = 0;
    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} {this.GetType().Name} blazes by you. Mmmmmmmm");
    }

    public override void Turn(string direction)
    {
      Console.WriteLine($"The {MainColor} {this.GetType().Name} aggressively turns {direction}.");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} {this.GetType().Name} burns up brakes to a stop.");
    }
  }
}