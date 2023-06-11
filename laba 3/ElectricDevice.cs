using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LAB3
{
    public class ElectricDevice
    {
        private string _Name;
        private double _Power;
        private int _Voltage;


        public void SetName(string name) { _Name = name; }
        public void SetPower(double power ) { _Power = power; }
        public void SetVoltage(int voltage) { _Voltage = voltage; }
        public string GetName() { return _Name; }
        public double GetPower() { return _Power; }
        public int GetVoltage() { return _Voltage; }
    }
}