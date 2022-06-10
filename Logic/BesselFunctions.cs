using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SearchKoef
{
    public static class Bessel
    {
        public static Complex I(double v, double x)
        {
            return EulerFormula(v * Math.PI / 2)  * SpecialFunctions.BesselJ(v, x * EulerFormula(Math.PI / 2));
        }

        public static Complex IDerivative(double v, double x)
        {
            return EulerFormula(v * Math.PI / 2) * JDerivative(v, x * EulerFormula(Math.PI / 2));
        }

        public static Complex JDerivative(double v, Complex x)
        {
            return 0.5 * (SpecialFunctions.BesselJ(v - 1, x) - SpecialFunctions.BesselJ(v + 1, x));
        }


        public static double JDerivative(double v, double x)
        {
            return 0.5 * (SpecialFunctions.BesselJ(v - 1, x) - SpecialFunctions.BesselJ(v + 1, x));
        }

        public static Complex EulerFormula(double x)
        {
            if (x < 0)
            {
                return new Complex(Math.Cos(x), -Math.Sin(x));
            }

            return new Complex(Math.Cos(x), Math.Sin(x));
        }
    }

}
