// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number + " в ^ " + n + " = " + NumberN(number, n));
int NumberN (int a, int b)
{
    int result = 1;
    for (int i = 0; i<b; i++)
    {
        result*=a;
    }
    return result;
}





  