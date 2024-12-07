using Tyuiu.NedelkinFA.Sprint4.Task5.V15.Lib;

namespace Tyuiu.NedelkinFA.Sprint4.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SumOfPositiveElements()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5]  { { -1, 2, -3, 4, -5 },
                                           { 1, -1, 2, -2, 3 },
                                           { -1, -2, -3, -4, -5 },
                                           { 5, 6, -7, 8, -9 },
                                           { -10, 11, -12, 13, -14 } };
            int res = ds.Calculate(mas2);
            int wait = 45;
            Assert.AreEqual(wait, res);
        }
    }
}