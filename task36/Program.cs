// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int length = WorkWithUser("Введите размер массива: ");
int minValue = WorkWithUser("Введите минимальное значение: ");
int maxValue = WorkWithUser("Введите максимальное значение: ");
int[] numbers = GetArray(length, minValue, maxValue);
PrintArray(numbers);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {SumOfOdd(numbers)}");



int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int[] GetArray(int size, int min, int max) 
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
int SumOfOdd(int[] array)
{
    int res = 0;
    for (int i = 1; i < array.Length; i++)// Здесь можно было шагом выбрать 2 и увеличивать i на 2
    // чтобы не проверять на четность.
    {
        if(i % 2 != 0) res += array[i];
    }
    return res;
}