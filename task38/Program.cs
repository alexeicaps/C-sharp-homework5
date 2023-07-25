// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int res = Prompt("Введите длину массива: ");
double[] newArray = GetArray(res);
Console.WriteLine(String.Join(" / ", newArray));
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {GetDiff(newArray)}");


double[] GetArray(int size)
{
    double[] newArr = new double[size];
    for (int i = 0; i < size; i++)
    {
        newArr[i] = new Random().NextDouble();
        newArr[i] = Math.Round(newArr[i], 4);
    }
    return newArr;
}


double GetDiff(double[] arr)
{
    double min = arr[0];
    double max = arr[0];

    foreach (double el in arr)
    {
        if (min > el) min = el;
        if (max < el) max = el;
    }
    return max - min;
}
