using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NedelkinFA.Sprint4.Task7.V30.Lib
{
    public class DataService : ISprint4Task7V30
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[n, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }
            int product = 1;
            bool hasEven = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] % 2 == 0)
                    {
                        product *= mtrx[i, j];
                        hasEven = true;
                    }
                }
            }
            return hasEven ? product : 0;
        }
    }
}