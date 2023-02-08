// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Важно: не использовать строки, использовать только арифметические действия.

int GetNumbersSum(int n)
{
    int sum = 0;
    int count = 0;
    if (n < 0)
        n *= (-1);
    while (n > 0)
    {
        sum = sum + (n % 10);
        n /= 10;
        count++;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int s = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {s} равна {GetNumbersSum(s)}");