// Задача 38: Задайте массив вещественных чисел (double).
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Введите количество элементов в массиве: "); // Вводим количество элементов массива
int len = int.Parse(Console.ReadLine());

int[] array = GetRandomArray(len, 0, 100); // Задает массив с заданными параметрами

int[] GetRandomArray(int size, int minValue, int maxValue) // Метод (функция) для генерации элементов массива по заданным параметрам
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }

    return result;
}