using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NedelkinFA.Sprint4.Task3.V10.Lib
{
    public class DataService : ISprint4Task3V10
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int max = array[2, 0];
            for (int j = 1; j < columns; j++)
            {
                if (array[2, j] > max)
                {
                    max = array[2, j];
                }
            }
            return max;
        }
    }
}
