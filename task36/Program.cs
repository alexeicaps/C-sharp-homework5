// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int sizeArray = Prompt("Введите длину массива: ");
int min = Prompt("Введите минимальное значение диапазона для элементов массива: ");
int max = Prompt("Введите максимальное значение диапазона для элементов массива: ");

int[] array = GetArray(sizeArray, min, max);


int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
        Console.Write($"{result[i]} ");
    }
    return result;
}

int oddNumbers(int[] arr)
{
    int sumElements = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        sumElements = sumElements + arr[i];
    }
    return sumElements;
}

int result = oddNumbers(array);
Console.WriteLine(" -> " + result);