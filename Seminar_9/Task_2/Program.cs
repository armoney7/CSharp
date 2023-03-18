// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
int summa = 0;

void NaturalNumbers(int num, int num1, int sum)
{
    if (num == num1 + 1)
    {
        Console.Write($"Сумма чисел в промежутке от первого до второго чисел -> {sum}");
        return;
    }
    sum += num;
    NaturalNumbers(num + 1, num1, sum);
}

NaturalNumbers(m, n, summa);