// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");

int n = Convert.ToInt32(Console.ReadLine());

int count = 0;

int [] a = new int [n];

for (int i = 0; i < n; i++)
{
    Console.Write($"A[{i + 1}] = ");
    a[i] = Convert.ToInt32(Console.ReadLine());
   
    if (a[i] >0)

    {
        count++;
    }
}
Console.WriteLine($"Количество положительных чисел: {count}");