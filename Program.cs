using System;
class test
{
    public static void Main ()
    {
        string a = Console.ReadLine ();
        int x = Convert.ToInt32 (a);
        double L = P1(x);
        double K = P2(x);
        Console.WriteLine(K);
        Console.WriteLine(L);

    }

    private static double P1(double f)
    {
        double v = Math.Pow(f ,2);
        return v;
    }
    private static double P2(double g)
    {
        double h = Math.Pow(g,3);
        return h;
    }
}