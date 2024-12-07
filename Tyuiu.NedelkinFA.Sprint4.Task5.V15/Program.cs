using Tyuiu.NedelkinFA.Sprint4.Task5.V15.Lib;
DataService ds  = new DataService();
Random rnd = new Random();
Console.WriteLine("kolichestvo strok v massive: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("kolichestvo stolb v massive: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] mtrx = new int[rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        mtrx[i, j] = rnd.Next(-1, 1);
    }
}
Console.WriteLine("\nMassive:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{mtrx[i, j]} \t");
    }
    Console.WriteLine();
}
int res = ds.Calculate(mtrx);
Console.WriteLine("summa nulevih elementov: " + res);
Console.ReadKey();