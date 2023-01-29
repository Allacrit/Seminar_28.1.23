Console.Clear();
Console.WriteLine("3. Написать программу масштабирования фигуры.");

double[] initCoord = { 1, 1, 1, 2, 2, 2, 2, 1 };

Console.WriteLine($"Начальные координаты: ");
PrintRectCoord(initCoord);

Console.Write("Введите значение для маштабировария: ");
int value = int.Parse(Console.ReadLine());

double[] actualCoord = ScaleRectangle(initCoord, value);

Console.WriteLine($"Координаты после масштабирования на {value}: ");
PrintRectCoord(actualCoord);


double[] ScaleRectangle(double[] coord, double n)
{
    double[] result = new double[8];

    result[0] = coord[0];
    result[1] = coord[1];

    result[4] = coord[0] + (coord[4] - coord[0]) * n;
    result[5] = coord[1] + (coord[5] - coord[1]) * n;

    result[2] = coord[0];
    result[3] = result[5];

    result[6] = result[4];
    result[7] = coord[1];

    return result;
}

void PrintRectCoord(double[] coord)
{
    Console.WriteLine($"({coord[2]}, {coord[3]})-----------({coord[4]}, {coord[5]})");
    Console.WriteLine($"   |                |");
    Console.WriteLine($"   |                |");
    Console.WriteLine($"({coord[0]}, {coord[1]})-----------({coord[6]}, {coord[7]})");
    Console.WriteLine();
}