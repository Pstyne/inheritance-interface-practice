using System;

namespace vehicles
{
  public class Vehicle
  {
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }
    public virtual void Drive()
    {
      Console.WriteLine($"The {MainColor} {this.GetType().Name} flashes by you. Vrooom!");
    }

    public virtual void Turn(string direction)
    {
      Console.WriteLine($"The {MainColor} {this.GetType().Name} carefully turns {direction}.");
    }
    public virtual void Stop()
    {
      Console.WriteLine($"The {MainColor} {this.GetType().Name} stops.");
    }
  }
}