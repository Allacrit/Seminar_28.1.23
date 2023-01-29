Console.Clear();
Console.WriteLine("1. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы.");

double k1 = 1;
double b1 = 1;
double k2 = 2;
double b2 = 2;
double expectedX = -1;
double expectedY = 0;
double[] actualResult = GetInersectionLines(k1, b1, k2, b2);

Console.WriteLine();
Console.WriteLine($"Прямые y={k1}x+{b1} и y={k2}x+{b2} пересекаются в точке: ({actualResult[0]}, {actualResult[1]}). Результат верен: {actualResult[0] == expectedX && actualResult[1] == expectedY}.");
Console.WriteLine();


double[] GetInersectionLines(double k1, double b1, double k2, double b2)
{
    double[] result = new double[2];
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = k1 * result[0] + b1;
    return result;
}