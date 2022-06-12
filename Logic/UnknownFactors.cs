using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SearchKoef
{
    public static class UnknownFactors
    {
        private static Complex X0(double ky, double p, double p1, double y, double a1, double a0, double m)
        {
            return R.BiDerivative(E(0, ky, a1, a0, m)) / R.AiDerivative(E(0, ky, a1, a0, m));
        }

        private static Complex QH(double h, double ky, double p, double p1, double y, double a1, double a0, double m)
        {
            return R.Ai(E(h, ky, a1, a0, m)) * X0( ky,  p,  p1,  y,  a1,  a0,  m) - R.Bi(E(h, ky, a1, a0, m));
        }
        
        private static Complex QHDerivative(double h, double ky, double p, double p1, double y, double a1, double a0, double m)
        {
            return R.AiDerivative(E(h, ky, a1, a0, m)) * X0(ky, p, p1, y, a1, a0, m) - R.BiDerivative(E(h, ky, a1, a0, m));
        }

        private static Complex D(double h, double ky, double p, double p1,  double y, double a1, double a0, double m)
        {
            return (new Complex(0, 2 * ky / p1) * Bessel.EulerFormula(-ky * h)) / ((1 / p * QHDerivative(h, ky, p, p1, y, a1, a0, m)) - (new Complex(0, ky / p1) * QH(h, ky, p, p1, y, a1, a0, m)));
        }

        public static Complex B(double h, double ky, double p, double p1, double y, double a1, double a0, double m, double a)
        {
            return ((D(h, ky, p, p1,  y,  a1,  a0,  m) * QH(h, ky, p, p1, y, a1, a0, m)) - Bessel.EulerFormula(-ky * Math.Cos(a * Math.PI / 180d) * h)) / Bessel.EulerFormula(ky * Math.Cos(a * Math.PI / 180d) * h);
        }

        public static double E(double y, double ky, double a1, double a0, double m)
        {
            return Math.Pow(Math.Pow(ky, 2) * a1, -2d / 3) * ((Math.Pow(ky, 2) * a1 * y) + (Math.Pow(ky, 2) * a0) - Math.Pow(m, 2));
        }

    }
}
