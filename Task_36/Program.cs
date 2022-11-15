// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите 
// сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int [] array = GetArray(size);

Console.WriteLine();

Console.WriteLine(String.Join(", ", array));

int [] GetArray (int size)
{
    int [] array = new int [size];
    for (int i = 0; i< size; i++)
    {
        array [i] = new Random().Next(-10, 10);
        int x = array [i];
        if (i % 2 == 1)
        {
             sum +=x;
        }
       
    }
    return array;
}


Console.WriteLine();
Console.Write($"Сумма чисел с нечетным индексом = {sum}");