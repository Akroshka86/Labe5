using System;
using System.Collections.Generic;
using System.Text;

namespace Лаб4
{
    class Power
    {
        public List<ElectricDevice> power = new List<ElectricDevice>();

        public double GetTotalPower()
        {
            double TotalPower = 0;

            foreach (ElectricDevice m in power)
            {
                TotalPower += m.GetPower();
            }
            return TotalPower;
        }
        public void ShowInfo() 
        {
            foreach (Interface m in power)
            {
                m.Print();
                Console.WriteLine();
            }
        }

    }
}
