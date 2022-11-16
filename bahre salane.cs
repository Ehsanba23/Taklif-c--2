using System;

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(seporde(a, b, c));

        int seporde(int a, int b, int c)
        {
            double temp = a;
            int year = 0;

            while (true)
            {
                if (temp >= c)
                {
                    break;
                }
                else
                {
                    temp += (temp * b) / 360;
                    year++;
                }
            }
            return year;
        }