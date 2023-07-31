using System;
using static SystemAcl.Console;

/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
           и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] TwoIntArr(int m, int n)
{
  int[,] arr = new int[m, n];
  for (m = 0; m < arr.GetLength(0); m++)
  {
    for (n = 0; n < arr.GetLength(1); n++)
    {
      arr[m, n] = new Random().Next(0, 10);
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
bool ElementValue(int[,] arrEl, int i, int j)
{
  for (int m = 0; m < arrEl.GetLength(0); m++)
  {
    for (int n = 0; n < arrEl.GetLength(1); n++)
    {
      if (m == i && n == j)
        return true;
    }
  }
  return false;
}


Console.Clear();
Console.Write("Введите количество строк (i) двумерного массива: ");
int i = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов (j) двумерного массива: ");
int j = int.Parse(Console.ReadLine());
Console.Write("Введите номер индекса (k) строки искомого элемента двумерного массива: ");
int k = int.Parse(Console.ReadLine());
Console.Write("Введите номер индекса (l) столбца искомого элемента двумерного массива: ");
int l = int.Parse(Console.ReadLine());

int[,] array = TwoIntArr(i, j);
PrintTwoIntArr(array);
Console.WriteLine();
if (ElementValue(array, k, l))
{
  Console.Write($"{k} и {l} -> {array[k, l]}");
}
else
{
  Console.Write($"{k} и {l} -> такого числа, с такими индексами, в массиве нет");
}

