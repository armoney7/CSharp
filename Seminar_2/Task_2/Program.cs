// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100) Console.Write("У данного числа нет третьей цифры");
else
{
    int n = num;
    int del = 10;
    int c = 0;
    while (n != 0)
    {
        n = num / del;
        del = del * 10;
        c += 1;
    }
    int num3 = num / Convert.ToInt32(Math.Pow(10, c - 3));
    int thirdNum = num3 % 10;
    Console.Write("Третья цифра заданного числа: " + thirdNum);
}
