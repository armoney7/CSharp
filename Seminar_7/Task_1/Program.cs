// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// Например:
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9 

double[,] CreateMatrixRndInt(int m, int n)
{
    double[,] arr = new double[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(new Random().Next(-10, 10) + new Random().NextDouble(), 1);
        }
    }
    return arr;
}

void PrintMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j], 4} | ");
            else Console.Write($"{arr[i, j], 4} | ");
        }
        Console.WriteLine();
    }
}

double[,] arrayCreate = CreateMatrixRndInt(3, 4);
PrintMatrix(arrayCreate);