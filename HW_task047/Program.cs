/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
           вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9     */


double[,] TwoDimenArr(int m, int n, double min, double max)
{
  double[,] arr = new double[m, n];
  for (m = 0; m < arr.GetLength(0); m++)
  {
    for (n = 0; n < arr.GetLength(1); n++)
    {
      arr[m, n] = min + (new Random().NextDouble()) * max;
    }
  }
  return arr;
}

void PrintTwoDimenArr(double[,] arrayPrint)
{
  for (int m = 0; m < arrayPrint.GetLength(0); m++)
  {
    for (int n = 0; n < arrayPrint.GetLength(1); n++)
    {
      Console.Write($"{arrayPrint[m, n]:f1} ");
    }
    Console.WriteLine();
  }
}


Console.Clear();
int i = 3;
int j = 4;
double minarr = -5.5;
double maxarr = 10.5;
Console.WriteLine($"m = {i}, n = {j}.");
Console.WriteLine();
PrintTwoDimenArr(TwoDimenArr(i, j, minarr, maxarr));
Console.WriteLine();