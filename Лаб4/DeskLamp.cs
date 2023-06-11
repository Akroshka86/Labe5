using System;
using System.Collections.Generic;
using System.Text;

namespace Лаб4
{
    class DeskLamp : ElectricDevice, Interface
    {
        private int _Brightness;
        public void SetBrightness(int brightness) { _Brightness = brightness; }
        public int GetBrightness() { return _Brightness; }
        public void Print()
        {
            Console.WriteLine($"Имя: {GetName()}");
            Console.WriteLine($"Мощность: {GetPower()}");
            Console.WriteLine($"Вольтаж: {GetVoltage()}");
            Console.WriteLine($"Яркость: {GetBrightness()}");
        }
    }
}
