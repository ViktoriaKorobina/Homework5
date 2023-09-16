// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int size = WorkWithUser("Введите размер массива: ");
int minValue = WorkWithUser("Введите нижний диапазон: ");// Лучше вводить 1
int maxValue = WorkWithUser("Введите верхний диапазон: ");// Лучше вводить 100
double[] numbers = GetArray(size, minValue, maxValue);
PrintArray(numbers);
double minEl = MinValue(numbers);
double maxEl = MaxValue(numbers);
Console.WriteLine($"Разница между минимальным {minEl} и максимальным {maxEl} равна {maxEl - minEl}");


int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double[] GetArray(int size, int min, int max) 
{
    double[] numbers = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        numbers[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);//Округляем до 2-ого знака после запятой
    }
    return numbers;
}
void PrintArray(double[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
    Console.WriteLine();
}
double MinValue(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}
double MaxValue(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}