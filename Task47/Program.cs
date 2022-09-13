// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
bool M = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов: ");
bool N = int.TryParse(Console.ReadLine(), out int n);

double[,] newArray = CreateArray(m, n);

PrintArray(newArray);

double[,] CreateArray(int m, int n)
{
    double[,] array2d = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = Convert.ToDouble(random.Next(-100, 100)) / 10;
        }
    }
    return array2d;
}

void PrintArray(double[,] array)
{
    double[,] printArray = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            printArray[i, j] = array[i, j];
            Console.Write($"{printArray[i, j]} ");
        }
        Console.WriteLine();
    }
}