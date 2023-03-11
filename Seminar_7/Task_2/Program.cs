// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void DecisionMatrix(int[,] arr)
{
    if(row < arr.GetLength(0) && column < arr.GetLength(1)) 
    {
        Console.Write($"{row}, {column} -> Число {arr[row, column]}");
    }
    else Console.Write($"{row}, {column} -> такого числа в массиве нет");
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j], 3} | ");
            else Console.Write($"{arr[i, j], 3} | ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
int[,] arrayCreate = CreateMatrixRndInt(3, 4);
PrintMatrix(arrayCreate);
Console.WriteLine();
DecisionMatrix(arrayCreate);