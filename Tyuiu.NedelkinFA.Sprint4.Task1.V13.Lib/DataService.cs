﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NedelkinFA.Sprint4.Task1.V13.Lib
{
    public class DataService : ISprint4Task1V13
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] > 10)
                {
                    sumArray += array[i];
                }
            }
            return sumArray;
        }
    }
}
