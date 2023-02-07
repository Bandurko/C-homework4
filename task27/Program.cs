// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Важно: не использовать строки, использовать только арифметические действия.

int GetNumbersSum(int num){ // n=3

    int count = 0; // count 0
    if (num < 0)
        num *= (-1); // n = n * (-1) 
    while (n > 0) // 0 > 0
    {
        n /= 10; // n = n / 10    n = 0
        count++; // count 3
        
    }
    return count;

    int result = 1;
    for (int i = 2; i <= count; i++){ // i <= n; 2 <= 3
        result *= i; // result
    }
    return result;
}