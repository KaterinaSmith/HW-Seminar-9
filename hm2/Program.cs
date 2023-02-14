// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных числе от M до N равна {SumNumbers(m, n)}");
int SumNumbers(int m, int n)
{
    if (m == 0) return (n * (n + 1)) / 2;
    else if (n == 0) return (m * (m + 1)) / 2;
    else if (m == n) return m;
    else if (m < n) return n + SumNumbers(m, n - 1);
    else return n + SumNumbers(m, n + 1);
}
Console.ReadLine();