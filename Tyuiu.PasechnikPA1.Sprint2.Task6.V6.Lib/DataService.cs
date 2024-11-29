using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PasechnikPA1.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string res1;
            switch (value1)
            {
                case 1: res1 = "пик"; break;
                case 2: res1 = "трефы"; break;
                case 3: res1 = "бубны"; break;
                case 4: res1 = "червы"; break;
                default: res1 = "Неподходящее значение для переменной"; break;
            }
            string res2;
            switch (value2)
            {
                case 6: res2 = "Шестерка"; break;
                case 7: res2 = "Семерка"; break;
                case 8: res2 = "Восьмерка"; break;
                case 9: res2 = "Девятка"; break;
                case 10: res2 = "Десятка"; break;
                case 11: res2 = "Валет"; break;
                case 12: res2 = "дама"; break;
                case 13: res2 = "Король"; break;
                case 14: res2 = "Туз"; break;
                default: res2 = "Неподходящее значение для переменной"; break;
            }
            string res = res2 + " " + res1;
            return res;
        }
    }
}
