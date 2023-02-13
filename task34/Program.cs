// Задача 34: Задайте массив заполненный
// случайными положительными трёхзначными числами (количество элементов пользователь вводит с клавиатуры,
//  а уже сами элементы делаем рандомно).
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Введите количество элементов в массиве: "); // Вводим количество элементов массива
int len = int.Parse(Console.ReadLine());

int[] array = GetRandomArray(len, 0, 1000); // Задает массив с заданными параметрами

int[] GetRandomArray(int size, int minValue, int maxValue) // Метод (функция) для генерации элементов массива по заданным параметрам
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }

    return result;
}

int EvenNumbersInArray(int[] array) // Метод (функция) который находит количество чётных чисел в массиве
{
    int countevenNumbers = 0;
    foreach (int index in array)
    {
        countevenNumbers += index % 2 == 0 ? 1 : 0;
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

    return countevenNumbers;
}

int evenNumbers = EvenNumbersInArray(array); // Присваивание переменной evenNumbers значения выполнения функции EvenNumbersInArray
Console.WriteLine($"Количество чётных чисел в массиве из {len} элементов - {evenNumbers}"); // Выводит полученные данные в консоль
