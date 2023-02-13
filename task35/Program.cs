// Доп
// Задача 35:Задайте одномерный массив из 123 случайных чисел [0: 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1

// [1, 2, 3, 6, 2]-> 0

// [10, 11, 12, 13, 14]-> 5

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

int indexSum = FindIndexSumSegment(10, 100); // Задает отрезок массив с заданными параметрами

int FindIndexSumSegment(int startSegment, int endSegment) // Метод (функция), который находит и суммирует количество элементов массива на заданном отрезке
{
    int indexSum = 0;
    foreach (int index in array)
    {
        indexSum += index >= startSegment && index < endSegment ? 1 : 0;
    }

    return indexSum;
}

Console.WriteLine($"В массиве [{String.Join(" ",array)}], на отрезке от 10 до 99 находятся {indexSum} элементов."); // Выводит полученные данные в консоль
