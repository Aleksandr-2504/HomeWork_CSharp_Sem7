using System;
using static System.Console;

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

void PrintIntArr(int[,] arrayPrint)
{
  for (int m = 0; m < arrayPrint.GetLength(0); m++)
  {
    for (int n = 0; n < arrayPrint.GetLength(1); n++)
    {
      Write($"{arrayPrint[m, n]} ");
    }
    WriteLine();
  }
}

void PrintDimenArr(double[] arrayPrintDim)
{
  Write("Среднее арифметическое каждого столбца: [");
  for (int m = 0; m < arrayPrintDim.Length - 1; m++)
  {
    Write($"{arrayPrintDim[m]:f1}; ");
  }
  Write($"{arrayPrintDim[arrayPrintDim.Length - 1]:f1}.]");
}

double[] ArithmetElem(int[,] arrayAri)
{
  double[] arrayD = new double[arrayAri.GetLength(1)];
  for (int j = 0; j < arrayAri.GetLength(1); j++)
  {
    for (int i = 0; i < arrayAri.GetLength(0); i++)
    {
      arrayD[j] += Convert.ToDouble(arrayAri[i, j]);
    }
    arrayD[j] /= arrayAri.GetLength(0);
  }
  return arrayD;
}
  
Clear();
int i = 3;
int j = 4;
int minarr = 0;
int maxarr = 9;

int[,] array = TwoIntArr(i, j, minarr, maxarr);
PrintIntArr(array);
PrintDimenArr(ArithmetElem(array));

