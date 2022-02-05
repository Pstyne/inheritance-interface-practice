using System.Collections.Generic;

namespace vehicles
{
  interface IRefuelStation<T>
  {
    int Capacity { get; set; }
    void Refuel(List<T> vehicles);
  }
}