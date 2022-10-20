// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = (number/10)%10; //Сначала написал так:(number/10)-(number/100)*10;
Console.WriteLine($"Исходное число {number}");
Console.WriteLine($"Результат {number1}");
