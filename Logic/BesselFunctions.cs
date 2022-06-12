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
            var test1 = EulerFormula(v * Math.PI / 2);
            var tets = EulerFormula(Math.PI / 2);
            var test2 = SpecialFunctions.BesselJ(v, x * EulerFormula(Math.PI / 2));
            return EulerFormula(v * Math.PI / 2)  * SpecialFunctions.BesselJ(v, x * EulerFormula(Math.PI / 2));
        }

        public static Complex IDerivative(double v, double x)
        {
            var test = EulerFormula(v * Math.PI / 2);
            var test1 = JDerivative(v, x * EulerFormula(Math.PI / 2));

            return EulerFormula(v * Math.PI / 2) * JDerivative(v, x * EulerFormula(Math.PI / 2));
        }

        public static Complex JDerivative(double v, Complex x)
        {
            var test1 = (SpecialFunctions.BesselJ(v - 1, x));
            return 0.5 * (SpecialFunctions.BesselJ(v - 1, x) - SpecialFunctions.BesselJ(v + 1, x));
        }


        public static double JDerivative(double v, double x)
        {
            var test1 = (SpecialFunctions.BesselJ(v - 1, x) - SpecialFunctions.BesselJ(v + 1, x));

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
