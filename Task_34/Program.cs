// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int count = 0;
int [] array = GetArray(size);

Console.WriteLine();

Console.WriteLine(String.Join(",", array));

int [] GetArray (int size)
{
    int [] array = new int [size];
    for (int i = 0; i< size; i++)
    {
        array [i] = new Random().Next(100, 1000);
        int x = array [i];
        if (x % 2 == 0)
        {
             count +=1;
        }
       
    }
    return array;
}


Console.WriteLine();
Console.Write($"Количество четных чисел: {count}");