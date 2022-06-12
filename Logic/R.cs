using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SearchKoef
{

    public static class R
    {
        public static Complex Ai(double E)
        {
            double z = 2d / 3d * Math.Pow(E, 3d / 2d);
            if (E >= 0)
            {
                return 1d / 3d * Math.Sqrt(E) * (Bessel.I(-1d / 3d, z) - Bessel.I(1d / 3d, z));
            }

            E = Math.Abs(E);

            return 1d / 3d * Math.Sqrt(E) * (SpecialFunctions.BesselJ(-1d / 3d, z) + SpecialFunctions.BesselI(1d / 3d, z));
        }

        public static Complex Bi(double E)
        {
            double z = 2d / 3d * Math.Pow(E, 3d / 2d);
            if (E >= 0)
            {
                return Math.Sqrt(E * 1d / 3d) * (Bessel.I(-1d / 3d, z) + Bessel.I(1d / 3d, z));
            }

            E = Math.Abs(E);

            return Math.Sqrt(E * 1d / 3d) * (SpecialFunctions.BesselJ(-1d / 3d, z) - SpecialFunctions.BesselI(1d / 3d, z));
        }

        public static Complex AiDerivative(double E)
        {
            double z = 2d / 3d * Math.Pow(E, 3d / 2d);
            if (E >= 0)
            {
                return (1d / 3d * 1 / (2 * Math.Sqrt(E)) * (Bessel.I(-1d / 3d, z) - Bessel.I(1d / 3d, z))) +
                  (1d / 3d * Math.Sqrt(E) * (Bessel.IDerivative(-1d / 3d, z) - Bessel.IDerivative(1d / 3d, z)));

            }

            E = Math.Abs(E);

            return (1d / 3d * 1 / (2 * Math.Sqrt(E)) * (SpecialFunctions.BesselJ(-1d / 3d, z) + SpecialFunctions.BesselI(1d / 3d, z))) +
                 (1d / 3d * Math.Sqrt(E) * (Bessel.JDerivative(-1d / 3d, z) + Bessel.JDerivative(1d / 3d, z)));
        }

        public static Complex BiDerivative(double E)
        {
            //E = Math.Abs(E);
            double z = 2d / 3d * Math.Pow(E, 3d / 2d);
            if (E >= 0)
            {
                var test1 = (Bessel.IDerivative(-1d / 3d, z));

                return (Math.Sqrt(1d / 3d) * 1 / (2 * Math.Sqrt(E)) * (Bessel.I(-1d / 3d, z) + Bessel.I(1d / 3d, z))) +
                      (Math.Sqrt(1d / 3d * E) * (Bessel.IDerivative(-1d / 3d, z) + Bessel.IDerivative(1d / 3d, z)));

            }

            E = Math.Abs(E);

            return (Math.Sqrt(1d / 3d) * 1 / (2 * Math.Sqrt(E)) * (SpecialFunctions.BesselJ(-1d / 3d, z) - SpecialFunctions.BesselI(1d / 3d, z))) +
                    (Math.Sqrt(1d / 3d * E) * (Bessel.JDerivative(-1d / 3d, z) - Bessel.JDerivative(1d / 3d, z)));

        }
    }
}