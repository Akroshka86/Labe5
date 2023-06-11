using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LAB3
{
    public class VacuumCleaner : ElectricDevice, Interface
    {
        private double _SuctionPower;
        public void SetSuctionPower(double suctionpower) { _SuctionPower = suctionpower; }
        public double GetSuctionPower() { return _SuctionPower; }
        public void Print()
        {
            Console.WriteLine($"Имя: {GetName()}");
            Console.WriteLine($"Исполнитель: {GetPower()}");
            Console.WriteLine($"Продолжительность: {GetVoltage()}");
            Console.WriteLine($"Темп: {GetSuctionPower()}");
        }

    }
}

