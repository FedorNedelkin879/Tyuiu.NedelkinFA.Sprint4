using Tyuiu.NedelkinFA.Sprint4.Task0.V15.Lib;

namespace Tyuiu.NedelkinFA.Sprint4.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] numsArray = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            int result = ds.GetMultOddArrEl(numsArray);
            int expected = 9 * 7 * 5 * 7 * 3 * 7 * 3;
            Assert.AreEqual(expected, result);
        }
    }
}
