using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Лаб3;

namespace Лаб5
{
    public partial class Form3 : Form
    {
        Form1 form1;
        public Form3(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (ClassBox.SelectedItem.ToString() == "Desk Lamp")
            {
                var Lamp = new Лаб3.DeskLamp();
                Lamp.SetName(NameBox.Text);
                Lamp.SetPower(Convert.ToDouble(PowerBox.Text));
                Lamp.SetVoltage(Convert.ToInt32(VoltageBox.Text));
                Lamp.SetBrightness(Convert.ToInt32(BrightnessBox.Text));
                Class1.pow.power.Add(Lamp);
                form1.listBox1.Items.Add(Class1.pow.power[Class1.pow.power.Count() - 1].GetName());
                form1.Power.Text = Class1.pow.GetTotalPower().ToString();
                this.Close();
            }
            if (ClassBox.SelectedItem.ToString() == "Refrigerator")
            {
                var Ref = new Лаб3.Refrigerator();
                Ref.SetName(NameBox.Text);
                Ref.SetPower(Convert.ToDouble(PowerBox.Text));
                Ref.SetVoltage(Convert.ToInt32(VoltageBox.Text));
                Ref.SetCapacity(Convert.ToDouble(CapacityBox.Text));
                Class1.pow.power.Add(Ref);
                form1.listBox1.Items.Add(Class1.pow.power[Class1.pow.power.Count() - 1].GetName());
                form1.Power.Text = Class1.pow.GetTotalPower().ToString();
                this.Close();
            }
            if (ClassBox.SelectedItem.ToString() == "Vacuum Cleaner")
            {
                var Vac = new Лаб3.VacuumCleaner();
                Vac.SetName(NameBox.Text); ;
                Vac.SetPower(Convert.ToDouble(PowerBox.Text));
                Vac.SetVoltage(Convert.ToInt32(VoltageBox.Text));
                Vac.SetSuctionPower(Convert.ToDouble(SuctionPowerBox.Text));
                Class1.pow.power.Add(Vac);
                form1.listBox1.Items.Add(Class1.pow.power[Class1.pow.power.Count() - 1].GetName());
                form1.Power.Text = Class1.pow.GetTotalPower().ToString();
                this.Close();
            }

        }


        private void ClassBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ClassBox.SelectedItem.ToString() == "Desk Lamp")
            {
                Brightness.Enabled = true;
                BrightnessBox.Enabled = true;
                Capacity.Enabled = false;
                CapacityBox.Enabled = false;
                SuctionPower.Enabled = false;
                SuctionPowerBox.Enabled = false;
            }
            if (ClassBox.SelectedItem.ToString() == "Refrigerator")
            {
                Brightness.Enabled = false;
                BrightnessBox.Enabled = false;
                Capacity.Enabled = true;
                CapacityBox.Enabled = true;
                SuctionPower.Enabled = false;
                SuctionPowerBox.Enabled = false;
            }
            if (ClassBox.SelectedItem.ToString() == "Vacuum Cleaner")
            {
                Brightness.Enabled = false;
                BrightnessBox.Enabled = false;
                Capacity.Enabled = false;
                CapacityBox.Enabled = false;
                SuctionPower.Enabled = true;
                SuctionPowerBox.Enabled = true;
            }
        }

        private void Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
