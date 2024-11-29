using Tyuiu.NedelkinFA.Sprint4.Task0.V15.Lib;

DataService ds = new DataService();
int[] numsArray = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };

Console.WriteLine("Исходный массив:");
foreach (int num in numsArray)
{
    Console.Write(num + "\t");
}
Console.WriteLine();

int result = ds.GetMultOddArrEl(numsArray);

Console.WriteLine("Произведение нечёт элем м " + result);

Console.ReadKey();
