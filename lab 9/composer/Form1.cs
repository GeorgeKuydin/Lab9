using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace composer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var jewelryBox = new JewelryBox { Name = "Квест Кімната" };
            var topTray = new Tray { Name = "Хорор" };
            //ringCompartment.AddContent("сапфірна прекраса");
            var ringCompartment = new Compartment { Name = "Наповнення" };

            ringCompartment.AddContent("Скрімер");
            ringCompartment.AddContent("Паска");
            ringCompartment.AddContent("Вавуки");
            topTray.Add(ringCompartment);
            jewelryBox.Add(topTray);
            jewelryBox.Display(0, textBox1);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            var jewelryBox = new JewelryBox { Name = "" };
            var topTray = new Tray { Name = "" };
            var ringCompartment = new Compartment { Name = "+" };
            ringCompartment.AddContent("Зникнення світла");
            topTray.Add(ringCompartment);
            jewelryBox.Add(ringCompartment);
            jewelryBox.Display(0, textBox1);
        }
    }
}
