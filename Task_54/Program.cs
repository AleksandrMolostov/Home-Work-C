// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(10);
        }
    }
    return result;
}

int [,] SortArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        for (int k = 0; k < array.GetLength(1) - 1; k++)
        {
            if (array [i, k] < array [i, k + 1])
            {
                int temp = array [i, k + 1];
                array [i, k + 1] = array [i, k];
                array [i, k] = temp;
            }
        }   
      }Console.WriteLine();
    }
    return array;
}


void PrintArray(int [,] inputAarray)
{
     for (int i = 0; i < inputAarray.GetLength(0); i++)
    {
        for (int j = 0; j < inputAarray.GetLength(1); j++)
    { 
        Console.Write($"{inputAarray[i, j]} ");
    }
    Console.WriteLine();
}
}
int [,] array1 = GetArray(rows, columns);

PrintArray(array1);

Console.WriteLine("_________");

PrintArray(SortArray(array1));

