// Задача 25: Напишите функцию, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int  GetRad(int A, int B){
    int result = 2;
    for (int i = 1; i <= B; i++){
        result = result * A;
    }
    return result;
}

Console.Clear();
Console.Write ("Введите число возводимое в степень: ");
int m = int.Parse (Console.ReadLine ());
Console.Write ("Введите степень: ");
int n = int.Parse (Console.ReadLine ());

Console.WriteLine($"Число {m} в степени {n} равно {GetRad(m, n)}");