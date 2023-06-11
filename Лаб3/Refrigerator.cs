using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Лаб3
{
    public class Refrigerator : ElectricDevice, Interface
    {
        private double _Capacity;
        public void SetCapacity(double capacity) { _Capacity = capacity; }
        public double GetCapacity() { return _Capacity; }
        public void Print()
        {
            Console.WriteLine($"Имя: {GetName()}");
            Console.WriteLine($"Исполнитель: {GetPower()}");
            Console.WriteLine($"Продолжительность: {GetVoltage()}");
            Console.WriteLine($"Темп: {GetCapacity()}");
        }
    }
}

