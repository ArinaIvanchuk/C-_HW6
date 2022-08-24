// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
int [] CreateArray ()
{
    Console.WriteLine("input numbers of array elements ");
    int size = Convert.ToInt32(Console.ReadLine());
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"input {i+1} element of array ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int [] myArray = CreateArray();
Console.Write($"{String.Join(",", myArray)}");
int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0)
    {
        count = count + 1;
    }
}
Console.Write($" -> {count}");