// Задача 52. Задайте двумерный массив из 
// целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int r = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [r, c];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix [i, j] = new Random().Next(10);

        Console.Write(matrix[i, j]+"\t");
    }
    Console.WriteLine();
}

double [] sum = new double [matrix.GetLength(0)];
for (int j = 0; j < matrix.GetLength(0); j++)
    {
        sum [j] = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            sum[j] += matrix[i, j];
        }
        Console.WriteLine($"Среднее арифметическое = {sum[j]/r}");
    }
      