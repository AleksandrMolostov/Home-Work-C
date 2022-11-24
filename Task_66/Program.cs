// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumber(int start, int end)
{
    if (end < start)
    {
        return 0;

    }
    if (end == start)
    {
        return start;
    }
    return (start + SumNumber(start + 1, end));

}
Console.WriteLine(SumNumber(m, n));