// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите размерность матрицы: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] Array(int n)
{
    int number = 1, h = 0;
    int size = n;
    int[,] arr = new int[n, n];
    if(size > 4 && size % 2 == 0) h = size/2 - 2;
    else if(size > 7 && size % 2 != 0) h = size/2 - 2;
    for (int i = 0; i < n + h; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j + i] = number;
            number++;
        }
        for (int k = i + 1; k < n + i; k++)
        {
            arr[k, n - 1 + i] = number;
            number++;
        }
        for (int l = n - 2 + i; l > 0 + i; l--)
        {
            arr[n - 1 + i, l] = number;
            number++;
        }
        for (int m = n - 1 + i; m > 0 + i; m--)
        {
            arr[m, i] = number;
            number++;
        }
        n = n - 2;
    }
    if (size % 2 != 0) arr[size / 2, size / 2] = size * size;
    return arr;
}

void WritingArray(int[,] array, int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j],4}");
        }
        Console.WriteLine();
    }
}

int[,] newArray = Array(num);
WritingArray(newArray, num);