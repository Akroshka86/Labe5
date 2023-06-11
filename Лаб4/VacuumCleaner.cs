using System;
using System.Collections.Generic;
using System.Text;

namespace Лаб4
{
    class VacuumCleaner : ElectricDevice, Interface
    {
        private double _SuctionPower;
        public void SetSuctionPower(double suctionpower) { _SuctionPower = suctionpower; }
        public double GetSuctionPower() { return _SuctionPower; }
        public void Print()
        {
            Console.WriteLine($"Имя: {GetName()}");
            Console.WriteLine($"Мощность: {GetPower()}");
            Console.WriteLine($"Вольтаж: {GetVoltage()}");
            Console.WriteLine($"Мощность всасывания: {GetSuctionPower()}");
        }

    }
}
