﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PasechnikPA1.Sprint2.Task3.V11.Lib
{
    public class DataService : ISprint2Task3V11
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 0) y = x + Math.Pow(((x - 15) / (x - 19)), x);
            else if (x == 0) y = (Math.Pow(x, 2) - Math.Cos(x * x) + 10) / (Math.Pow(x, 2) - Math.Sin(x * x) + 12);
            else if ((x > -15) && (x < 0)) y = Math.Pow((1 + 1 / Math.Pow(x, 2)), x);
            else y = x + 10 * x - (1 / x);
            return Math.Round(y, 3);
        }
    }
}
