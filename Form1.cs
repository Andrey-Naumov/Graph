using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using SearchKoef;
using MathNet.Numerics;

namespace PressureGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chartPressure.Series["Series0"].Points.Clear();

            double h = 2, ky = 4, density = 0.4, l1 = 0.5, l2 = 4, a0 = 1.8, a1 = 1.5, m =2;
            double density1 = l1 * h + l2; 
            Complex ps = new Complex();


            double a = 0;
            do
            {
                double kySnelius = ky * Math.Cos(a * Math.PI / 180d);

                ps = UnknownFactors.B(h, kySnelius, ky, density, density1, a1, a0, m);

                this.chartPressure.Series[0].Points.AddXY(a, Complex.Abs(ps));

                a += 10;
            }
            while (a <= 90);
        }
    }
}
