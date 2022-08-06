//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Method

int CountPositiveNums(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        int value = int.Parse(arr[i]);
        if (value > 0) count++;
    }
    return count;
}

// Code

Console.WriteLine("Введите несколько целых чисел через пробел");
string[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($"Количество введенных положительных чисел: {CountPositiveNums(array)}");
