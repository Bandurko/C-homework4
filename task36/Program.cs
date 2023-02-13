// Задача 36: Задайте одномерный массив,
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Введите минимальное число, которое может быть в массиве: "); // Вводим минимальное число массива
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное число, которое может быть в массиве: "); // Вводим максимальное число массива
int max = int.Parse(Console.ReadLine());
Console.Write("Введите количество элементов в массиве: "); // Вводим количество элементов массива
int len = int.Parse(Console.ReadLine());

int[] array = GetRandomArray(len, min, max +1); // Задает массив с заданными параметрами

int[] GetRandomArray(int size, int minValue, int maxValue) // Метод (функция) для генерации элементов массива по заданным параметрам
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }

    return result;
}

int GetOddIndexSum(int[] array) // Метод (функция) который находит сумму элементов, стоящих на нечётных позициях.
{
    int oddindexSum = 0;
    int i = 1;
    for (i = 1; i < array.Length; i+=2)
    {
        oddindexSum = oddindexSum + array[i];
    }

    return oddindexSum;
}

int oiSum = GetOddIndexSum(array); // Присваивание переменной oiSum значения выполнения функции GetOddIndexSum
Console.WriteLine($"В массиве [{String.Join(" ",array)}], сумма элементов, стоящих на нечётных позициях равна {oiSum}."); // Выводит полученные данные в консоль
