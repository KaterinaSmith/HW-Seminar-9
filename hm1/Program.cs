// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
TopToLow(num, count);


void TopToLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        TopToLow(n, count + 1);
        Console.Write(count + ", ");
    }
}
