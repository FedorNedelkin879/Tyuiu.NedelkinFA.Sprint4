﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NedelkinFA.Sprint4.Task4.V19.Lib
{
    public class DataService : ISprint4Task4V19
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0;
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
