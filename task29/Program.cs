// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GetArray(int min, int max){
    int[] result = new int[8];
    for (int i = 0; i < 8; i++){
        result[i] = new Random().Next(min, (max + 1));
    }
    return result;
}

Console.Clear();
Console.Write("Введите минимальное число, которое может быть в массиве: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное число, которое может быть в массиве: ");
int n2 = int.Parse(Console.ReadLine());
int[] array = GetArray(n1, n2);
Console.Write($"[{String.Join(", ", array)}]");