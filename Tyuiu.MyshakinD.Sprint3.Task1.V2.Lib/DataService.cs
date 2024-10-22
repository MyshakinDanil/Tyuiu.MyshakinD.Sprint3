using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MyshakinD.Sprint3.Task1.V2.Lib
{
    public class DataService : ISprint3Task1V2
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double res = 0;
            double temp = 0;
            while (startValue < stopValue + 1)
            {
                temp = Math.Sin(startValue) * 0.5;
                res += temp;
                startValue++;
            }
            return Math.Round(res, 3);
        }
    }
}
