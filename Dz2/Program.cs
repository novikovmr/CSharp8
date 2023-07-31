/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] CreateMatrix(int rows, int collumns)
{
    int[,] matrix = new int[rows, collumns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collumns; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0);i++)
    {
        for (int  j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] CollumnSum(int[,] matrix)
{
    int[] Sum = new int[matrix.GetLength(0)];
    int minValue = Sum[0];
    int indexOfMinSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        Sum[i] = sum;
    }
    return Sum;
}

int CheckMinSum (int[] sum)
{
    int minValue = sum[0];
    int count = 0;
    for (int i = 1; i < sum.Length; i++)
    {
        if (minValue > sum[i]) 
        {
            minValue = sum[i];
            count = i;
        }
            
    }
    return count;
}

Console.Clear();

Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int collumns = Convert.ToInt32(Console.ReadLine());
if (rows != collumns) Console.WriteLine("Ошибка. Задайте прямоугольный массив.");
else 
{
    int[,] matrix = CreateMatrix(rows, collumns);
    PrintMatrix(matrix);
    int[] Sum = CollumnSum(matrix);
    
    int numberOfCollumn= CheckMinSum(Sum);
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {numberOfCollumn}");
}
