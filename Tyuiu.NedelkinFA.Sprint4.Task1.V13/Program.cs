using Tyuiu.NedelkinFA.Sprint4.Task1.V13.Lib;

DataService ds = new DataService();
int len = 10;
int[] numsArray = new int[len];

Console.WriteLine("Введите 10 элементов массива (в диапазоне от 0 до 8):");
for (int i = 0; i < len; i++)
{
    numsArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Массив:");
foreach (int num in numsArray)
{
    Console.Write(num + "\t");
}
Console.WriteLine();

int res = ds.Calculate(numsArray);
Console.WriteLine($"Сумма четных элементов массива: {res}");
Console.ReadKey();
