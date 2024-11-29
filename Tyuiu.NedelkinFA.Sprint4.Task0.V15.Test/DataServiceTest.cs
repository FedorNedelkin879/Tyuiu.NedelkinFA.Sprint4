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
            int[] numsArray = { 4, 0, 3, 0, 10 };
            int[] res = ds.Calculate(numsArray);
            int[] numswaitArray = {4,1,3,1,10};
            CollectionAssert.AreEqual(numswaitArray, res);
        }
    }
}