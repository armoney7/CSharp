// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());

double[] Array(int num)
{
    double[] array = new double[num];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().Next(1, 100) + new Random().NextDouble(), 1);
    }
    return array;
}

double Difference(double[] array)
{
    double max = array[0];
    double min = array[0];
    double result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Math.Round(result = max - min,1);
    return result;
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

double[] array = Array(num);
PrintArray(array);
Difference(array);
Console.Write($" -> {Difference(array)}"); 