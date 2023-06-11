using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Лаб3;

namespace Лаб5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form3 formadd = new Form3(this);
            formadd.Show();
        }

        private void Deletedevice_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Class1.pow.power.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            };
            Power.Text = Class1.pow.GetTotalPower().ToString();

        }

        private void Editdevice_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Class1.pow.power.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            };
            Power.Text = Class1.pow.GetTotalPower().ToString();
            Form3 formadd = new Form3(this);
            formadd.Show();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ValuePower_Click(object sender, EventArgs e)
        {

        }
    }
}
