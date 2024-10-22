﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MyshakinD.Sprint3.Task0.V19.Lib
{
    public class DataService : ISprint3Task0V19
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            double temp = 0;
            for (int i = startValue; i < stopValue; i++)
            {
                temp = 1 / (Math.Cos(i) + 2);
                sum += Math.Pow(temp, 2);
            }
            return sum;
        }
    }
}