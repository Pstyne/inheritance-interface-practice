using System;

namespace vehicles
{
  public class Cessna : Vehicle, IGasVehicle  // Propellor light aircraft
  {
    public double FuelCapacity { get; set; } = 55;
    public double CurrentTankPercentage { get; set; }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} {this.GetType().Name} flys by you. Zzzzzoooommmm!");
    }

    public override void Turn(string direction)
    {
      Console.WriteLine($"The {MainColor} {this.GetType().Name} veryy very carefully turns {direction}.");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} {this.GetType().Name} slowly rolls to a stop.");
    }
  }
}