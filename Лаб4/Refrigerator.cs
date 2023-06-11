using System;
using System.Collections.Generic;
using System.Text;

namespace Лаб4
{
    class Refrigerator : ElectricDevice, Interface
    {
        private double _Capacity;
        public void SetCapacity(double capacity) { _Capacity = capacity; }
        public double GetCapacity() { return _Capacity; }
        public void Print()
        {
            Console.WriteLine($"Имя: {GetName()}");
            Console.WriteLine($"Мощность: {GetPower()}");
            Console.WriteLine($"Вольтаж: {GetVoltage()}");
            Console.WriteLine($"Вместимость: {GetCapacity()}");
        }
    }
}
