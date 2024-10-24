﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MyshakinD.Sprint3.Task7.V10.Lib
{
    public class DataService : ISprint3Task7V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            double temp = 0;
            int len = stopValue - startValue + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                temp = Math.Sin(x) + 3;
                if (temp == 0)
                {
                    valueArray[count] = 0;
                    count++;
                }
                else
                {
                    y = ((5 * x + 2.5) / temp) + 2 * x + Math.Cos(x);
                    valueArray[count] = Math.Round(y, 2);
                    count++;
                }
            }
            return valueArray;
        }
    }
}
