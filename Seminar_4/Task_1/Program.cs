// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int Function(int a1, int b1)
{
    int comp = 1;
    for (int step = 1; step <= b1; step++)
    {
        comp = comp * a1;
    }
    return comp;
}
int result = Function(a, b);
Console.Write($"Число {a} в степени {b} = {result}");
