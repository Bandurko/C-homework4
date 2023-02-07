// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GetArray(int num){
    int[] result = new int[8];
    for (int i = 0; i < 8; i++){
        result[i] = new Random().Next((num + 1));
    }
    return result;
}

Console.Clear();
Console.Write("Введите максимальное число в массиве: ");
int n = int.Parse(Console.ReadLine());
int[] array = GetArray(n);
Console.Write($"[{String.Join(", ", array)}]");