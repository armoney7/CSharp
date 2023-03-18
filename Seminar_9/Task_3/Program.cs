// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

int NaturalNumbers(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
     if ((n != 0) && (m == 0))
        return NaturalNumbers(n - 1, 1);
    else
        return NaturalNumbers(n - 1, NaturalNumbers(n, m - 1));
}

int num = NaturalNumbers(n, m);
Console.Write(num);