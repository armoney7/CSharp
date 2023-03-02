// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: ");
int num = int.Parse(Console.ReadLine());

int[] Array(int num)
{
    int[] array = new int[num];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,101);
    }
    return array;
}

int OddPos(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i] ;
    }
    return sum;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

int[] array = Array(num);
PrintArray(array);
OddPos(array);
Console.Write($" -> {OddPos(array)}");
