// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double [] array = GetArray(size);

Console.WriteLine();

Console.WriteLine(String.Join(", ", array));

double [] GetArray (int size)
{
    double [] array = new double [size];
    for (int i = 0; i< size; i++)
    {
        array [i] = new Random().Next(10);
    }
    return array;
}
double max = array [0];
double min = array [0];

for (int i = 0; i < size; i++)
{
    if (array [i] > max ) max = array [i];
    if (array [i] < min ) min = array [i];
}
    
Console.WriteLine();

Console.Write($"max[i] - min[i] = {max - min}");
