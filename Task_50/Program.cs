// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

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

Console.Write("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n > r || m > c)
{
Console.WriteLine("Элемент отсутствует");
}
else
{
    Console.WriteLine("Элемент: " + matrix[n ,m]);
}