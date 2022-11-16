using System;
class test
{
    public static void Main ()
    {
        string a = Console.ReadLine ();
        string b = Console.ReadLine();
        string c = Console.ReadLine();

        int x = Convert.ToInt32 (a);
        int y = Convert.ToInt32(b);
        int z = Convert.ToInt32(c);
        double delta (Math.Pow (b,2)) -4(a * c);
        if (delta > 0)
        {
            double r;
            r = (-b) + Math.Sqrt(delta) / (2 * a);
            double rr;
            rr = (-b) - Math.Sqrt(delta) / (2 * a);
        }
        else if (delta == 0)
        {
            double rrr;
            rrr = (-b) / (2 * a);
        }
        else
        {
            Console.WriteLine("معادله ریشه حقیقی ندارد");
        }
        Console.WriteLine(moadel);
        Console.WriteLine(moadele);

    }

    private static int moadele(int f , int g , int l)
    {
        int v = f + g + l;
        return v;
    }
    private static double moadel(double g)
    {
        double h = Math.Pow(g,3);
        return h;
    }
}