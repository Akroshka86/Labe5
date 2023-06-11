using System;
using System.Collections.Generic;
using System.Text;

namespace Лаб4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Включенные в розетку устройства\n");
            var m1 = new VacuumCleaner();
            m1.SetName("Polaris PVC 2004RI");
            m1.SetPower(2000);
            m1.SetVoltage(220);
            m1.SetSuctionPower(560);

            var m2 = new VacuumCleaner();
            m2.SetName("Samsung VC21K5177HB/EV");
            m2.SetPower(2100);
            m2.SetVoltage(230);
            m2.SetSuctionPower(440);

            var m3 = new Refrigerator();
            m3.SetName("Samsung RF50N5861B1/WT");
            m3.SetPower(350);
            m3.SetVoltage(220);
            m3.SetCapacity(554);

            var m4 = new DeskLamp();
            m4.SetName("Xiaomi Mi Smart LED Desk Lamp Pro");
            m4.SetPower(12.5);
            m4.SetVoltage(100);
            m4.SetBrightness(700);

            var listObject = new Power();
            listObject.power.Add(m1);
            listObject.power.Add(m2);
            listObject.power.Add(m3);
            listObject.power.Add(m4);

            listObject.ShowInfo();
            Console.WriteLine($"Общая потребляемая мощность: {listObject.GetTotalPower()}");
            Console.ReadKey();
        }

    }
}
