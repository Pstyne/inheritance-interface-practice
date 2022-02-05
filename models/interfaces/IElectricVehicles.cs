namespace vehicles
{
  public interface IElectricVehicle
  {
    double BatteryKWh { get; set; }
    double CurrentChargePercentage { get; set; }
    string MainColor { get; }
    void ChargeBattery()
    {
      CurrentChargePercentage = 100;
    }
  }
}