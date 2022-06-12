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

            double h = 2, ky = 2, kx = 2, p = 0.1, p1 = 1.5, x = 100, y = 10;

            Complex sum = new Complex();

            double a = 0;
            do
            {
                sum = UnknownFactors.B(h, ky, p, p1, 10, 1, 2, 2, a);

                this.chartPressure.Series[0].Points.AddXY(a, Complex.Abs(sum));

                a += 5;
            }
            while (a <= 90);
            //*   Bessel.EulerFormula((x* kx * Math.Sin(tet * Math.PI / 180d)) + (y *ky * Math.Cos(tet * Math.PI / 180d)));
        }
    }
}
