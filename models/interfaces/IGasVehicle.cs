namespace vehicles
{
  public interface IGasVehicle
  {
    double FuelCapacity { get; set; }
    double CurrentTankPercentage { get; set; }
    string MainColor { get; }

    void RefuelTank()
    {
      CurrentTankPercentage = 100;
    }
  }
}