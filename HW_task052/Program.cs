/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
           в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/



int[,] TwoIntArr(int m, int n, int min, int max)
{
  int[,] arr = new int[m, n];
  for (m = 0; m < arr.GetLength(0); m++)
  {
    for (n = 0; n < arr.GetLength(1); n++)
    {
      arr[m, n] = new Random().Next(min, max);
    }
  }
  return arr;
}

void PrintTwoIntArr(int[,] arrayPrint)
{
  for (int m = 0; m < arrayPrint.GetLength(0); m++)
  {
    for (int n = 0; n < arrayPrint.GetLength(1); n++)
    {
      Console.Write($"{arrayPrint[m, n]} ");
    }
    Console.WriteLine();
  }
}

void PrintTDimenArr(double[,] arrayPrint)
{
  double[,] arrPr = new double[arrayPrint.GetLength(0), arrayPrint.GetLength(1)];
  for (int m = 0; m < arrPr.GetLength(0); m++)
  {
    for (int n = 0; n < arrPr.GetLength(0)); n++)
    {
      Console.Write($"{arrPr[m, n]} ");
    }
  }
  {
      Console.Write(@$"Среднее арифметическое каждого столбца: 
      {String.Join("; ", PrintTDimenArr(arrayPrint))}.");
  }
  Console.WriteLine();
}


double[] ArithmetElem(int[,] arrayAri)
{
  double[] arrayD = new double[arrayAri.Length];
  for (int j = 0; j < arrayAri.GetLength(1); j++)
  {
    arrayD[j] = 0;
    for (int i = 0; i < arrayAri.GetLength(0); j++)
    {
      arrayD[j] += double.Parse(arrayAri[j, i]);
    }
    arrayD[i] = arrayD[i] / arrayAri.GetLength(0);
  }
  return arrayD;
} 

Console.Clear();
int i = 3;
int j = 4;
int minarr = 1;
int maxarr = 10;
Console.WriteLine($"m = {i}, n = {j}.");
Console.WriteLine();
PrintTwoIntArr(TwoIntArr(i, j, minarr, maxarr));
Console.WriteLine();

double[] arrayDab = ArithmetElem(TwoIntArr(i, j, minarr, maxarr));
PrintTDimenArr(arrayDab);

