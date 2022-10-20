// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день 
// недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите цифру дня недели");
int number = int.Parse(Console.ReadLine());


if (number>7)
{
Console.WriteLine($"{number}-некорректный ввод"); // Когда вводим число 8 выдает: 8-некорректный ввод и 8 рабочий день. Как убрать 8 рабочий день?
}

if (number==6||number==7)
{
Console.WriteLine($"{number} выходной день");
}

else if (number>=1||number<6)
{
Console.WriteLine($"{number} рабочий день");
}