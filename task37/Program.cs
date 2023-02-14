﻿// Доп
// Задача 37:Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6]-> 36 21

Console.Clear();
Console.Write("Введите элементы массива через пробел: "); // Ввод строки элементоа массива разделенных пробелами " "
string elements = Console.ReadLine();

int[] baseArray = GetArrayFromString(elements); // Задает массив

Console.WriteLine(String.Join(" ", ResultArray(baseArray))); // Выводим элементы массива разделенных " " в виде строки

int[] GetArrayFromString(string stringArray) // Метод (функция) для заполнения массива элементами из введеной строки 
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int[] ResultArray(int[] array) // Метод (функция) для вычисления произведения пар чисел
{
    int size = (array.Length + 1)/ 2;
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1) result[size-1] = array[array.Length / 2];
    return result;
}
