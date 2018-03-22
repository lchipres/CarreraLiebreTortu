using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarreraL
{
    public partial class Form1 : Form
    {
        private BadBunny b1 = new BadBunny();
        private Tortuga t1 = new Tortuga();
        private Pista p1 = new Pista();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = simCar();
        }

        public string simCar()
        {
            string s = "";
            while (b1.getPasos() <= p1.getLong() && t1.getPasos() <= p1.getLong())
            {
                b1.correr();
                s += b1.ToString();
                t1.correr();
                s += t1.ToString();
            }
            return s;
        }

    }
}
