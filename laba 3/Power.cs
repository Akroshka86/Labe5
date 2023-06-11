using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб3
{
    public class Power
    {
        public List<ElectricDevice> power = new List<ElectricDevice>();

        public double GetTotalPower() // Изменить название
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
