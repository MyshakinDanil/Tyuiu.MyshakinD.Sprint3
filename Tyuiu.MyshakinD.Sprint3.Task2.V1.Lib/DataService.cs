using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MyshakinD.Sprint3.Task2.V1.Lib
{
    public class DataService : ISprint3Task2V1
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double temp = 0;
            double res = 0;
            do
            {
                temp = Math.Sin(startValue) * Math.Pow(0.5, 2);
                res += temp;
                startValue++;
            } while (startValue < stopValue + 1);
            return Math.Round(res, 3);
        }
    }
}
