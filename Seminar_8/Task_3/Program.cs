// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FirstCreateMatrixRndInt(int m, int n)
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

int[,] SecondCreateMatrixRndInt(int m, int n)
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

int[,] CompositionMatrix(int[,] firArr, int[,] secArr)
{
    int[,] newArr = new int[firArr.GetLength(0), secArr.GetLength(1)];
    if (firArr.GetLength(1) == secArr.GetLength(0))
    {
        for (int i = 0; i < firArr.GetLength(0); i++)
        {
            for (int j = 0; j < secArr.GetLength(1); j++)
            {
                for (int k = 0; k < secArr.GetLength(0); k++)
                {
                    newArr[i, j] += firArr[i, k] * secArr[k, j];
                }
            }
        }
    }
    return newArr;
} 

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} | ");
            else Console.Write($"{arr[i, j],3} | ");
        }
        Console.WriteLine();
    }
}

int[,] firstMatrixCreate = FirstCreateMatrixRndInt(3, 3);
int[,] secondMatrixCreate = SecondCreateMatrixRndInt(3, 3);
int[,] newMatrix = CompositionMatrix(firstMatrixCreate, secondMatrixCreate);
Console.WriteLine();
Console.WriteLine("Первая матрица: ");
PrintMatrix(firstMatrixCreate);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
PrintMatrix(secondMatrixCreate);
Console.WriteLine();
if(firstMatrixCreate.GetLength(1) == secondMatrixCreate.GetLength(0))
{
    Console.WriteLine("Произведение первой и второй матрицы: ");
    PrintMatrix(newMatrix);
}
else Console.Write("Перемножение таких матриц является невозможным");