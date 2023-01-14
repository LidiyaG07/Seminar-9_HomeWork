/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите значение M и N: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int summ = 0;
SummNums(m, n, summ);


void SummNums(int m, int n, int summ)
{
    if (m > n)
    {
        Console.WriteLine("Введите числа от меньшего к большему.");
        return;
    }

    for (int i = m; i <= n; i++)
    {
        summ += i;
    }
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна {summ}.");

}
