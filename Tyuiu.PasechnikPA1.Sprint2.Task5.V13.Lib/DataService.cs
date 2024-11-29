using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PasechnikPA1.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            string res = "";
            switch (n)
            {
                case 29:
                    switch (m)
                    {
                        case 2:
                            n = 01;
                            m = 03;
                            break;
                        default:
                            n = 30;
                            break;
                    }
                    break;

                default:
                    n = n + 1;
                    break;


                case 30:
                    switch (m)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            n = 31;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            n = 01;
                            m += 1;
                            break;
                    }
                    break;
                case 31:
                    switch (m)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                            n = 01;
                            m += 1;
                            break;
                        case 12:
                            n = 01;
                            m = 01;
                            g += 1;
                            break;
                    }
                    break;
            }
            if (m >= 1 && m < 10 && n > 10)
            {
                res = $"{n}.0{m}.{g}";
            }
            else if (n >= 1 && n < 10 && m >= 10)
            {
                res = $"0{n}.{m}.{g}";
            }
            else if ((m >= 1 && m < 10) && (n >= 1 && n < 10))
            {
                res = $"0{n}.0{m}.{g}";
            }
            else
            {
                res = $"{n}.{m}.{g}";
            }
            return res;
        }
    }
}
