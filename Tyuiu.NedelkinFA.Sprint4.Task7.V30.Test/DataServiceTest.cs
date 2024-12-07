using Tyuiu.NedelkinFA.Sprint4.Task7.V30.Lib;

namespace Tyuiu.NedelkinFA.Sprint4.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int[,] mtrx = new int[5, 3] { { 6, 8, 4 }, { 2, 5, 9 }, { 1, 3, 7 }, { 1, 5, 9 }, { 6, 4, 8 } };
            DataService ds = new DataService();
            int res = ds.Calculate(mtrx);
            int wait = 768;
            Assert.AreEqual(wait, res);
        }
    }
}