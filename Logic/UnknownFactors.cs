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
        private static Complex X0(double kySnelius, double a1, double a0, double m)
        {
            var test = E(0, kySnelius, a1, a0, m);
            var test3 = R.BiDerivative(E(0, kySnelius, a1, a0, m));
            var test4 = R.AiDerivative(E(0, kySnelius, a1, a0, m));
            var test2 = R.BiDerivative(E(0, kySnelius, a1, a0, m)) / R.AiDerivative(E(0, kySnelius, a1, a0, m));
            return R.BiDerivative(E(0, kySnelius, a1, a0, m)) / R.AiDerivative(E(0, kySnelius, a1, a0, m));

        }

        private static Complex QH(double h,double kySnelius, double ky, double density, double density1, double a1, double a0, double m)
        {
            var test = R.Ai(E(h, ky, a1, a0, m));
            var test1 = X0(ky, a1, a0, m);
            var test2 = R.Bi(E(h, ky, a1, a0, m));

            return R.Ai(E(h, kySnelius, a1, a0, m)) * X0(ky, a1, a0, m) - R.Bi(E(h, kySnelius, a1, a0, m));
        }

        private static Complex QHDerivative(double h, double kySnelius, double ky,  double a1, double a0, double m)
        {
            return R.AiDerivative(E(h, kySnelius, a1, a0, m)) * X0(kySnelius, a1, a0, m) - R.BiDerivative(E(h, kySnelius, a1, a0, m));
        }

        private static Complex D(double h,double kySnelius, double ky, double density, double density1, double a1, double a0, double m)
        {
            return (new Complex(0, 2 * kySnelius / density1) * Bessel.EulerFormula(-kySnelius * h)) / ((1 / density * QHDerivative(h, kySnelius, ky, a1, a0, m)) - (new Complex(0, kySnelius / density1) * QH(h, kySnelius, ky, density, density1, a1, a0, m)));
        }

        public static Complex B(double h, double kySnelius, double ky, double density, double density1, double a1, double a0, double m)
        {
            //var test1 = D(h, ky, density, density1, a1, a0, m);
            //var test2 = QH(h, ky, density, density1, a1, a0, m);
            //var test3 = Bessel.EulerFormula(-ky * h);
            //var test4 = Bessel.EulerFormula(ky * h);

            return ((D(h, kySnelius, ky, density, density1, a1, a0, m) * QH(h, kySnelius, ky, density, density1, a1, a0, m)) - Bessel.EulerFormula(-kySnelius * h)) / Bessel.EulerFormula(kySnelius * h);
        }

        public static double E(double y, double kySnelius, double a1, double a0, double m)
        {
            var test = Math.Pow(Math.Pow(kySnelius, 2) * a1, -2d / 3);
            var test1 = Math.Pow(Math.Pow(kySnelius, 2) * a1, -2d / 3) * ((Math.Pow(kySnelius, 2) * a1 * y) + (Math.Pow(kySnelius, 2) * a0) - Math.Pow(m, 2));
            return Math.Pow(Math.Pow(kySnelius, 2) * a1, -2d / 3) * ((Math.Pow(kySnelius, 2) * a1 * y) + (Math.Pow(kySnelius, 2) * a0) - Math.Pow(m, 2));
        }

    }
}
