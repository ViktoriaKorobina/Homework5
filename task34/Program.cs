// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int length = WorkWithUser("Введите размер массива: ");
int minValue = WorkWithUser("Введите минимальное значение: ");
int maxValue = WorkWithUser("Введите максимальное значение: ");
int[] array = GetArray(length, minValue, maxValue);
PrintArray(array);
Console.WriteLine($"Количество четных элементов в массиве равно {Honest(array)}");

int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int[] GetArray(int size, int min, int max) // Здесь аргументом передаются минимальное
// и максимальное значение, но предполагается, что пользователь введет 100 и 999,
// чтобы заполнить массив трехзначными числами.
{
    int[] numbers = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        numbers[i] = rnd.Next(min, max + 1);
    }
    return numbers;
}
void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
    Console.WriteLine();
}
int Honest(int[] array)
{
    int countHonest = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) countHonest++;
    }
    return countHonest;
}