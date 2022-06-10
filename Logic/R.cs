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
            double z = 2d / 3d * Math.Pow(E, 2d / 3d);
            if (E >= 0)
            {
                // return 1d / 3d * Math.Abs(E) * (SpecialFunctions.BesselI(-1d / 3d, z) - SpecialFunctions.BesselI(1d / 3d, z));
                return 1d / 3d * Math.Abs(E) * (Bessel.I(-1d / 3d, z) - Bessel.I(1d / 3d, z));

            }

            E = Math.Abs(E);

            return 1d / 3d * Math.Abs(E) * (SpecialFunctions.BesselJ(-1d / 3d, z) + SpecialFunctions.BesselI(1d / 3d, z));
        }

        public static Complex Bi(double E)
        {
            double z = 2d / 3d * Math.Pow(E, 2d / 3d);
            if (E >= 0)
            {
                return Math.Abs(E * 1d / 3d) * (Bessel.I(-1d / 3d, z) + Bessel.I(1d / 3d, z));
            }

            E = Math.Abs(E);

            return Math.Abs(E * 1d / 3d) * (SpecialFunctions.BesselJ(-1d / 3d, z) - SpecialFunctions.BesselI(1d / 3d, z));
        }

        public static Complex AiDerivative(double E)
        {
            double z = 2d / 3d * Math.Pow(E, 2d / 3d);
            if (E >= 0)
            {
                return (1d / 3d * 1 / (2 * Math.Abs(E)) * (Bessel.I(-1d / 3d, z) - Bessel.I(1d / 3d, z))) +
                  (1d / 3d * Math.Abs(E) * (Bessel.IDerivative(-1d / 3d, z) - Bessel.IDerivative(1d / 3d, z)));

            }

            E = Math.Abs(E);

            return (1d / 3d * 1 / (2 * Math.Abs(E)) * (SpecialFunctions.BesselJ(-1d / 3d, z) + SpecialFunctions.BesselI(1d / 3d, z))) +
                 (1d / 3d * Math.Abs(E) * (Bessel.JDerivative(-1d / 3d, z) + Bessel.JDerivative(1d / 3d, z)));

        }

        public static Complex BiDerivative(double E)
        {
            double z = 2d / 3d * Math.Pow(E, 2d / 3d);
            if (E >= 0)
            {
                return ( Math.Abs(1d / 3d) * 1 / (2 * Math.Abs(E)) * (Bessel.I(-1d / 3d, z) + Bessel.I(1d / 3d, z))) +
                      ( Math.Abs(1d / 3d * E) * (Bessel.IDerivative(-1d / 3d, z) + Bessel.IDerivative(1d / 3d, z)));

            }

            E = Math.Abs(E);

            return (Math.Abs(1d / 3d) * 1 / (2 * Math.Abs(E)) * (SpecialFunctions.BesselJ(-1d / 3d, z) - SpecialFunctions.BesselI(1d / 3d, z))) +
                    (Math.Abs(1d / 3d *E) * (Bessel.JDerivative(-1d / 3d, z) - Bessel.JDerivative(1d / 3d, z)));

        }
    }

    //public class R
    //{
    //    private readonly int m;
    //    private readonly double k1;
    //    private readonly double q1;
    //    private readonly double q2;
    //    private readonly double e;

    //    //private double? R1;
    //    //private double? R1Derivative;

    //    private List<double> a = new List<double>() { 1, 0 };
    //    private List<double> B = new List<double>();

    //    public R(int m, double k1, double q1, double q2, double e = 1E-20)
    //    {
    //        this.m = m;
    //        this.k1 = k1;
    //        this.q1 = q1;
    //        this.q2 = q2;
    //        this.e = e;

    //        a = new List<double>() { 1, 0 };
    //        B = new List<double>();

    //        //R1 = null;
    //        //R1Derivative = null;
    //    }

    //    #region Coment
    //    //public int M { get { return m; } set { m = value; a = new List<double>(); B = new List<double>(); } }
    //    //public int K1 { get { return k1; } set { k1 = value; } }
    //    //public int Q1 { get { return q1; } set { q1 = value; } }
    //    //public int Q2 { get { return q2; } set { q2 = value; } }



    //    //public  double a(uint index)
    //    //{
    //    //    if (index == 0)
    //    //    {
    //    //        return 1;
    //    //    }
    //    //    else if (index == 1)
    //    //    {
    //    //        return 0;
    //    //    }
    //    //    else if (index == 2)
    //    //    {
    //    //        return -(Math.Pow(k1, 2) * Math.Pow(q2, 2) * a(index - 2)) / (Math.Pow(index, 2) + 2 * index * m);
    //    //    }
    //    //    else if (index == 3)
    //    //    {
    //    //        return (-(Math.Pow(k1, 2) * Math.Pow(q2, 2) * a(index - 2)) - (2 * Math.Pow(k1, 2) * q1 * q2) * a(index - 3)) / (Math.Pow(index, 2) + 2 * index * m);
    //    //    }
    //    //    else if (index > 3)
    //    //    {
    //    //        return (-(Math.Pow(k1, 2) * Math.Pow(q2, 2) * a(index - 2)) - (2 * Math.Pow(k1, 2) * q1 * q2) * a(index - 3) - (Math.Pow(k1, 2) * Math.Pow(q1, 2) * a(index - 4))) / (Math.Pow(index, 2) + 2 * index * m);
    //    //    }

    //    //    return 0;
    //    //}
    //    #endregion

    //    private void addAlpha()
    //    {
    //        int n = a.Count;

    //        if (n == 2)
    //        {
    //            double a2 = -(Math.Pow(k1, 2) * Math.Pow(q2, 2) * a[n - 2]) / (Math.Pow(n, 2) + 2 * n * m);
    //            a.Add(a2);
    //        }
    //        else if (n == 3)
    //        {
    //            double a3 = (-(Math.Pow(k1, 2) * Math.Pow(q2, 2) * a[n - 2]) - (2 * Math.Pow(k1, 2) * q1 * q2) * a[n - 3]) / (6 * m + 9);
    //            a.Add(a3);
    //        }
    //        else if (n > 3)
    //        {
    //            double an = (-(Math.Pow(k1, 2) * Math.Pow(q2, 2) * a[n - 2]) - (2 * Math.Pow(k1, 2) * q1 * q2) * a[n - 3] - (Math.Pow(k1, 2) * Math.Pow(q1, 2) * a[n - 4])) / (Math.Pow(n, 2) + 2 * n * m);
    //            a.Add(an);
    //        }
    //    }

    //    public double GetR1Derivative(double r)
    //    {
    //        double R1 = 0, R1BeforeStep = 0;
    //        int n = 0;
    //        do
    //        {
    //            if (a.Count > n)
    //            {
    //                R1 += (n + m) * a[n] * Math.Pow(r, n + m - 1);

    //                if ((Math.Abs(R1 - R1BeforeStep) < e && R1 != R1BeforeStep) || n > 200)
    //                {
    //                    break;
    //                }

    //                R1BeforeStep = R1;

    //                n++;
    //                continue;
    //            }

    //            addAlpha();
    //        }
    //        while (true);

    //        return R1;
    //    }

    //    public double GetR1(double r)
    //    {
    //        double R1 = 0, R1BeforeStep = 0;

    //        int n = 0;
    //        do
    //        {
    //            if (a.Count > n)
    //            {
    //                R1 += a[n] * Math.Pow(r, n + m);

    //                if ((Math.Abs(R1 - R1BeforeStep) < e && R1 != R1BeforeStep) || n > 200)
    //                {
    //                    break;
    //                }

    //                R1BeforeStep = R1;

    //                n++;
    //                continue;
    //            }

    //            addAlpha();
    //        }
    //        while (true);

    //        return R1;
    //    }


    //    private void addBetta()
    //    {
    //        if (!B.Any())
    //        {
    //            B = MethodGausa.GetDecision(GetBettaSystem()).ToList();
    //            B.Add(1); // B2m
    //        }

    //        int i = B.Count;

    //        if (i == 1)
    //        {
    //            double B1 = -2 * (m + i) * a[i] / (Math.Pow(i, 2) + 2 * i * m);
    //            B.Add(B1);
    //        }
    //        else if (i == 2)
    //        {
    //            double B2 = (-(2 * (m + i) * a[i]) - (Math.Pow(k1, 2) * Math.Pow(q2, 2) * B[i - 2])) / (Math.Pow(i, 2) + 2 * i * m);
    //            B.Add(B2);
    //        }
    //        else if (i == 3)
    //        {
    //            double B3 = (-(2 * (m + i) * a[i]) - (Math.Pow(k1, 2) * Math.Pow(q2, 2) * B[i - 2]) - (2 * Math.Pow(k1, 2) * q1 * q2) * B[i - 3]) / (Math.Pow(i, 2) + 2 * i * m);
    //            B.Add(B3);
    //        }
    //        else if (i > 3)
    //        {
    //            double Bn = (-(2 * (m + i) * a[i]) - (Math.Pow(k1, 2) * Math.Pow(q2, 2) * B[i - 2]) - (2 * Math.Pow(k1, 2) * q1 * q2) * B[i - 3] - (Math.Pow(k1, 2) * Math.Pow(q1, 2) * B[i - 4])) / (Math.Pow(i, 2) + 2 * i * m);
    //            B.Add(Bn);
    //        }
    //    }

    //    public double GetR2Derivative(double r)
    //    {

    //        double R2 = GetR1Derivative(r) * Math.Log(r) + (1 / r *  GetR1(r)), R2BeforeStep = 0;

    //        int n = 0;
    //        do
    //        {
    //            if (B.Count > n)
    //            {
    //                R2 += (n - m) * B[n] * Math.Pow(r, n - m - 1);

    //                if ((Math.Abs(R2 - R2BeforeStep) < e && R2 != R2BeforeStep) || n > 200)
    //                {
    //                    break;
    //                }

    //                R2BeforeStep = R2;

    //                n++;
    //                continue;
    //            }

    //            while (a.Count <= n)
    //            {
    //                addAlpha();
    //            }

    //            addBetta();

    //        }
    //        while (true);

    //        return R2;
    //    }

    //    public double GetR2(double r)
    //    {
    //        double R2 = GetR1(r) * Math.Log(r), R2BeforeStep = 0;

    //        for (int k = 0; k <= 2 * m - 1; k++)
    //        {
    //            R2 += B[k] * Math.Pow(r, k - m);
    //        }

    //        int i = 2 * m;
    //        do
    //        {
    //            if (B.Count > i)
    //            {
    //                R2 += B[i] * Math.Pow(r, i - m);

    //                if ((Math.Abs(R2 - R2BeforeStep) < e && R2 != R2BeforeStep) || i > 200)
    //                {
    //                    break;
    //                }

    //                R2BeforeStep = R2;

    //                i++;
    //                continue;
    //            }

    //            while (a.Count <= i)
    //            {
    //                addAlpha();
    //            }

    //            addBetta();

    //        }
    //        while (true);

    //        return R2;
    //    }

    //    private double[,] GetBettaSystem()
    //    {
    //        double[,] Slau = new double[2 * m, 2 * m + 1];

    //        if (!a.Any())
    //        {
    //            addAlpha();
    //        }

    //        for (int n = 1; n <= 2 * m; n++)
    //        {
    //            if (n == 1)
    //            {
    //                Slau[n - 1, n] = 1;

    //                Slau[n - 1, Slau.GetLength(1) - 1] = 0;
    //            }
    //            else if (n == 2 * m)
    //            {
    //                if (2 * m == 2)
    //                {
    //                    Slau[n - 1, n - 2] = Math.Pow(k1, 2) * Math.Pow(q2, 2);
    //                }
    //                if (2 * m >= 4)
    //                {
    //                    Slau[n - 1, n - 2] = Math.Pow(k1, 2) * Math.Pow(q2, 2);
    //                    Slau[n - 1, n - 3] = 2 * Math.Pow(k1, 2) * q1 * q2;
    //                    Slau[n - 1, n - 4] = Math.Pow(k1, 2) * Math.Pow(q1, 2);
    //                }

    //                Slau[n - 1, Slau.GetLength(1) - 1] = -2 * m * a[0];
    //            }
    //            else if (n == 2)
    //            {
    //                Slau[n - 1, n] = Math.Pow(n, 2) - 2 * n * m;
    //                Slau[n - 1, n - 2] = Math.Pow(k1, 2) * Math.Pow(q2, 2);

    //                Slau[n - 1, Slau.GetLength(1) - 1] = 0;
    //            }
    //            else if (n == 3)
    //            {
    //                Slau[n - 1, n] = Math.Pow(n, 2) - 2 * n * m;
    //                Slau[n - 1, n - 2] = Math.Pow(k1, 2) * Math.Pow(q2, 2);
    //                Slau[n - 1, n - 3] = 2 * Math.Pow(k1, 2) * q1 * q2;

    //                Slau[n - 1, Slau.GetLength(1) - 1] = 0;
    //            }
    //            else if (n < 2 * m)
    //            {
    //                Slau[n - 1, n] = Math.Pow(n, 2) - 2 * n * m;
    //                Slau[n - 1, n - 2] = Math.Pow(k1, 2) * Math.Pow(q2, 2);
    //                Slau[n - 1, n - 3] = 2 * Math.Pow(k1, 2) * q1 * q2;
    //                Slau[n - 1, n - 4] = Math.Pow(k1, 2) * Math.Pow(q1, 2);

    //                Slau[n - 1, Slau.GetLength(1) - 1] = 0;
    //            }
    //        }

    //        return Slau;
    //    }
    //}
}
