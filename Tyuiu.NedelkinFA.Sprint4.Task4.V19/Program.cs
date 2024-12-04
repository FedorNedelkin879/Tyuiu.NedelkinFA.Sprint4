using Tyuiu.NedelkinFA.Sprint4.Task4.V19.Lib;
DataService ds = new DataService();
Console.WriteLine("kolich strok");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("kolich stolb");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] mtrx = new int[rows, columns];
for  (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.WriteLine($"napishi {i}, {j} element");
        mtrx[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("\nMassive");
for (int i = 0;i < columns; i++)
{
    for (int j = 0;j < rows; j++)
    {
        Console.WriteLine($"{mtrx[i,j]} \t");
    }
}
int res = ds.Calculate(mtrx);
Console.WriteLine("nul elem:" + res);
Console.ReadKey();