using Tyuiu.NedelkinFA.Sprint4.Task3.V10.Lib;

int[,] mtrx = new int[5, 5] { { 5, 7, 6, 6, 5 },
                              { 5, 5, 5, 4, 6 },
                              { 8, 5, 7, 4, 7 },
                              { 7, 6, 7, 4, 7 },
                              { 5, 8, 7, 8, 8 } };
int rows = mtrx.GetUpperBound(0) + 1;
int columns = mtrx.Length / rows;
DataService ds = new DataService();
int res = ds.Calculate(mtrx);
Console.WriteLine(res);
Console.ReadKey();
