// Задача 36: Задайте одномерный массив,
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = GetRandomArray(123, 0, 1000); // Задает массив с заданными параметрами

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
    foreach (int index in array)
    {
        oddindexSum += index % 2 == 1 ? 1 : 0;
    }
    
    /* Аналогично следущим строкам
     
    int countevenNumbers = 0;
    int i = 0;
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        countevenNumbers = countevenNumbers + 1;
    }
    */

    return oddIndexSum;
}

Console.WriteLine($"В массиве [{String.Join(" ",array)}], на отрезке от 10 до 99 находятся {indexSum} элементов."); // Выводит полученные данные в консоль



