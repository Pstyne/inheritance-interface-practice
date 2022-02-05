using System.Collections.Generic;

namespace vehicles
{
  class Program
  {
    static void Main(string[] args)
    {
      Zero fxs = new Zero();
      Zero fx = new Zero();
      Tesla modelS = new Tesla();

      //***********************************************/

      Ram ram = new Ram ();
      Cessna cessna150 = new Cessna ();
      
      //* --------------------------------------------------

      Zero redZero = new Zero(){
        MainColor = "Red"
      };

      Cessna purpleCessna = new Cessna(){
        MainColor = "Purple"
      };

      Tesla blackTesla = new Tesla(){
        MainColor = "Black"
      };

      Ram yellowRam = new Ram(){
        MainColor = "Yellow"
      };

      List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
          fx, fxs, modelS, redZero, blackTesla
      };

      List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
          ram, cessna150, purpleCessna, yellowRam
      };

      GasStation gasStation = new GasStation();
      gasStation.Refuel(gasVehicles);

      BatteryStation batteryStation = new BatteryStation();
      batteryStation.Refuel(electricVehicles);
    }
  }

}
