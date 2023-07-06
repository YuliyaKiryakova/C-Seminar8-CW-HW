/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
/* теория для себя - если первая матрица [i,j], то вторая должна быть [j,n], а их произведение [i,n]-!!!
количество столбцов первой матрицы должно равняться кол-ву строк второй матрицы-!!!
*/

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

int[,] MultiArray(int[,] array1, int[,] array2)
{
    int[,] array = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(0); j++)
        {
            for (int n = 0; n < array2.GetLength(1); n++)
            {
                array[i, n] += array1[i, j] * array2[j, n];
            }
        }
    }
    return array;
}

int rows1 = InputNum("Введите количество строк первого массива: ");
int cols1 = InputNum("Введите количество столбцов первого массива: ");
int rows2 = InputNum("Введите количество строк второго массива: ");
int cols2 = InputNum("Введите количество столбцов второго массива: ");

if (cols1 == rows2)
{
    int minValue = InputNum("Введите минимальное значение элемента: ");
    int maxValue = InputNum("Введите максимальное значение элемента: ");

    int[,] myArray1 = Create2DArray(rows1, cols1);
    int[,] myArray2 = Create2DArray(rows2, cols2);
    Fill2DArray(myArray1, minValue, maxValue);
    Fill2DArray(myArray2, minValue, maxValue);
    Print2DArray(myArray1);
    Console.WriteLine();
    Print2DArray(myArray2);
    Console.WriteLine();
    int[,] myArray = MultiArray(myArray1, myArray2);
    Print2DArray(myArray);
}
else
    Console.WriteLine("Эти массивы нельзя перемножать..");
