using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Включен в розетку");
            var m1 = new VacuumCleaner();
            m1.SetName("Sky");
            m1.SetPower(445);
            m1.SetVoltage(7);
            m1.SetSuctionPower(237.2);

            var m2 = new VacuumCleaner();
            m2.SetName("EARFQUAKE");
            m2.SetPower(457);
            m2.SetVoltage(5);
            m2.SetSuctionPower(85.9);

            var m3 = new Refrigerator();
            m3.SetName("Close Eyes");
            m3.SetPower(457);
            m3.SetVoltage(57);
            m3.SetCapacity(90.3);

            var m4 = new DeskLamp();
            m4.SetName("Bones");
            m4.SetPower(4574);
            m4.SetVoltage(4);
            m4.SetBrightness(75);

            var listObject = new Power();
            listObject.power.Add(m1);
            listObject.power.Add(m2);
            listObject.power.Add(m3);
            listObject.power.Add(m4);

            listObject.ShowInfo();
            Console.WriteLine($"Общая продолжительность: {listObject.GetTotalPower()}");
            Console.ReadKey();
        }

    }
}
