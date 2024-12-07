using Tyuiu.NedelkinFA.Sprint4.Task5.V15.Lib;
using System;

DataService ds = new DataService();
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
        mtrx[i, j] = rnd.Next(-6, 5);
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
Console.WriteLine("summa polozhitel'nykh elementov: " + res);
Console.ReadKey();