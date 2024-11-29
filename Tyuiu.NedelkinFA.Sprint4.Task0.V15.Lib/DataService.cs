using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NedelkinFA.Sprint4.Task0.V15.Lib
{
    public class DataService : ISprint4Task0V15
    {
        public int GetMultOddArrEl(int[] array)
        {
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] == 0)
                {
                    array[i] = 1;
                }
            }
            return array;
        }
    }
}
