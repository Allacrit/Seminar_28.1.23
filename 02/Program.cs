
Console.Clear();
Console.WriteLine("2. Показать числа Фибоначчи");

Console.Write("Введите количество чисел вывода: ");
int value = int.Parse(Console.ReadLine());

int[] actualResult = FillArrayFibonacci(value);
Console.Write($"Первые {value} чисел Фиббоначи: ");
PrintArray(actualResult);


int[] FillArrayFibonacci(int n)
{
    int[] result = new int[n];
    result[0] = 0;
    if (n > 1) result[1] = 1;
    for (int i = 2; i < n; i++)
        result[i] = result[i - 1] + result[i - 2];
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}