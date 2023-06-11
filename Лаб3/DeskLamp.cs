using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Лаб3
{
    public class DeskLamp : ElectricDevice, Interface
    {
        private int _Brightness;
        public void SetBrightness(int brightness) { _Brightness = brightness; }
        public int GetBrightness() { return _Brightness; }
        public void Print()
        {
            Console.WriteLine($"Имя: {GetName()}");
            Console.WriteLine($"Исполнитель: {GetPower()}");
            Console.WriteLine($"Продолжительность: {GetVoltage()}");
            Console.WriteLine($"Темп: {GetBrightness()}");
        }
    }
}



