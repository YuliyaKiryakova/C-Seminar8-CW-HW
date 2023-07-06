/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols)
{
    return new int[rows, cols];
}

void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write($"{array[i]}, ");
// }

int[] SumRows(int[,] array)
{
    int size = array.GetLength(0);
    int[] sum = new int[size];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];
        }
    }
    return sum;
}
void MinSumRows(int[] sum)
{
    int minIndex = 0;
    for (int i = 1; i < sum.Length; i++)
    {
        if (sum[i] < sum[minIndex]) minIndex = i;
    }
    Console.WriteLine($"Индекс строки с минимальной суммой элементов - {minIndex}");
}

int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");

if (rows != cols)
{
    int minValue = InputNum("Введите минимальное значение элемента: ");
    int maxValue = InputNum("Введите максимальное значение элемента: ");

    int[,] myArray = Create2DArray(rows, cols);
    Fill2DArray(myArray, minValue, maxValue);
    Print2DArray(myArray);
    Console.WriteLine();
    int[] mySum = SumRows(myArray);
    // PrintArray(mySum);
    // Console.WriteLine();
    MinSumRows(mySum);
}
else
    Console.WriteLine("Это не прямоугольный массив..");
