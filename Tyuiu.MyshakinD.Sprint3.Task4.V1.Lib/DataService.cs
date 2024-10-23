using System.Diagnostics.CodeAnalysis;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MyshakinD.Sprint3.Task4.V1.Lib
{
    public class DataService : ISprint3Task4V1
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;
            for (int i = startValue; i < stopValue + 1; i++)
            {
                if (i == 0)
                {
                    break;
                }
                double temp = Math.Sin(i) / i;
                sum += temp;
            }
            return Math.Round(sum, 3);
        }
    }
}
