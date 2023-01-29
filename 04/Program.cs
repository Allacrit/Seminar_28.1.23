Console.Clear();
Console.WriteLine("4. Написать программу копирования массива.");

int[] initArr = { 0, 1, 2, 3, 4, 5, 6 };
int[] actualArr = CopyArray(initArr);

Console.WriteLine();
PrintArray(initArr, preStr: "Исходный массив: ");
PrintArray(actualArr, preStr: "Скопированный массив: ");
Console.WriteLine();


int[] CopyArray(int[] arr)
{
    int[] result = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
        result[i] = arr[i];
    return result;
}

void PrintArray(int[] arr, string preStr = "")
{
    Console.Write(preStr);
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}