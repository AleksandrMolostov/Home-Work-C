// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в 
// каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n)
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

int[,] RowMinSum(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array [i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
        Console.WriteLine();
        Console.Write($"{minSumRow+1} строка");
    
    } return array;
}

void PrintArray(int[,] inputAarray)
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
int[,] array1 = GetArray(rows, columns);

PrintArray(array1);

Console.WriteLine("_________");

PrintArray(RowMinSum(array1));