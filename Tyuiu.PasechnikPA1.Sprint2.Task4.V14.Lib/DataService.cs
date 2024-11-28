using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PasechnikPA1.Sprint2.Task4.V14.Lib
{
    public class DataService : ISprint2Task4V14
    {
        public double Calculate(double x, double y)
        {
            double z = x * 3 < Math.Sqrt(y) + 20 ? Math.Pow(2 + (1 / Math.Pow(x, 3)), y) : (Math.Pow(y, 3) - Math.Cos(Math.Pow(x, 3)) + 10) / (Math.Pow(x, 3) - Math.Sin(Math.Pow(y, 3)) + 12);
            return Math.Round(z, 3);
        }
    }
}
