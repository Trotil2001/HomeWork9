/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int rec(int m, int n)
{
    if (m == n) return m;
    if (m < n)
        return rec(m, n - 1) + n;
    else return rec(n, m - 1) + m;
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВведите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Сумма чисел от " + m + " до " + n + " равна: " + rec(m, n));