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


int[] ElementValue(int[,] arrEl, int i, int j)
{
  int[] arr2 = new int[4];
  int[,] arrEl2 = new int[arrEl.GetLength(0), arrEl.GetLength(1)];
  for (int m = 0; m < arrEl2.GetLength(0); m++)
  {
    if (i == m)
    {
      for (int n = 0; n < arrEl2.GetLength(1); n++)
      {
        if (j == n)
        {
          arr2[0] = arrEl[i, j];
          arr2[1] = i;
          arr2[2] = j;
          arr2[3] = 0;
        }
      }
    }
    else
    {
      arr2[0] = 0;
      arr2[1] = i;
      arr2[2] = j;
      arr2[3] = -1;
    }
  }
  return arr2;
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

int[] arr3 = ElementValue(array, k, l);

if (arr3[3] != -1)
{
  Console.Write($"{arr3[1]} и {arr3[2]} -> {arr3[0]}");
}
else
{
  Console.Write($"{k} и {l} -> такого числа, с такими индексами, в массиве нет");
}


//int[,] array = TwoIntArr(i, j);
/*
if (ElementValue(array, k, l) == false)
  Console.WriteLine($"{k}{l} -> {array[k, l]}");
else
  Console.WriteLine($"{k}{l} -> такого числа, с такими индексами, в массиве нет");
*/
