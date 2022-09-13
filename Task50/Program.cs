// Задача 50. Напишите программу, которая на вход принимает число и ищет в двумерном массиве, и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 7 -> 0 , 2
// 5 -> 1 , 0
// 18 -> нет такого элемента

Console.Write("Введите кол-во строк массива: ");
bool M = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите кол-во столбцов массива: ");
bool N = int.TryParse(Console.ReadLine(), out int n);
Console.Write("Введите значение для поиска в массиве: ");
bool X = int.TryParse(Console.ReadLine(), out int x);

int[,] newArray = new int[m, n];

int[,] result = CreateArray2D(m, n);
PrintArray(result);
Console.WriteLine();
GetNumberInArray2D(result);

int[,] CreateArray2D(int m, int n)
{
    Random random = new Random();
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = random.Next(0, 11);
        }
    }
    return newArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetNumberInArray2D(int[,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == x)
            {
                count++;
                Console.WriteLine($"Значение {x} находится в  {i}|{j}");
            }
        }
    }
    if (count == 0)
    {
        Console.WriteLine($"Значение {x} отсутствует");
    }
}
