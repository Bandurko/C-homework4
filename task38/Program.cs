// Задача 38: Задайте массив вещественных чисел (double).
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Введите количество элементов в массиве: "); // Вводим количество элементов массива
int len = int.Parse(Console.ReadLine());

double[] array = GetRandomArray(len, 0, 100); // Задает массив с заданными параметрами

double[] GetRandomArray(int size, int minValue, int maxValue) // Метод (функция) для генерации элементов массива (вещественных чисел (double)) по заданным параметрам
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        Random x = new Random();
        result[i] = Convert.ToDouble(x.Next(maxValue * 100 - minValue) / 100.0);
    }

    return result;
}

double GetDiffMaxMin(double[] array) // Метод нахождения разницы между максимальным и минимальным значениями элементов массива
{
    double max = array[0];
    for (int j = 0; j < array.Length; j++){
        if (array[j] > max) max = array[j];
    }

    double min = array[0];
    for (int k = 0; k < array.Length; k++){
        if (array[k] < min) min = array[k];
    }

    double diffmaxmin = max - min;

    return diffmaxmin;

}

double diff = GetDiffMaxMin(array); // Присваивание переменной diff значения выполнения функции GetDiffMaxMin

Console.WriteLine($"Разница между максимальным и минимальным элементами массива [{String.Join(" ",array)}] равна {diff:f2}"); // Выводим элементы массива и разницу между максимальным и минимальным элементпми этого массива