/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

// не повторяющиеся не сделала..как?))

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,,] Create3DArray(int rows, int cols, int layers)
{
    return new int[rows, cols, layers];
}

void Fill3DArray(int[,,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int l = 0; l < array.GetLength(2); l++)
                array[i, j, l] = rnd.Next(min, max + 1);
}

void Print3DArray(int[,,] array)
{
    for (int l = 0; l < array.GetLength(2); l++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, l]} ({i}, {j}, {l})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");
int layers = InputNum("Введите количество слоев: ");
int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

if (minValue > 9 && minValue < 100 && maxValue > 9 && maxValue < 100)
{
    int[,,] myArray = Create3DArray(rows, cols, layers);
    Fill3DArray(myArray, minValue, maxValue);
    Print3DArray(myArray);
}
else
    Console.WriteLine("Введен интервал не двухзначных чисел..");
