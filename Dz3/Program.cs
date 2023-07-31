/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


int InputNumb(string message)
{
    Console.Write(message);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int[,] CreateMatrix(int row, int collumn)
{
    int[,] matrix = new int[row, collumn];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < collumn; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MultMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}


Console.Clear();

int row1 = InputNumb($"\n Введите количество строк 1й матрицы: ");
int collumns1 = InputNumb($"\n Введите количество стобцов 1й матрицы: ");
int row2 = InputNumb($"\n Введите количество строк 2й матрицы: ");
int collumns2 = InputNumb($"\n Введите количество стобцов 2й матрицы: ");
if (row1 != collumns2) Console.WriteLine($"\n Ошибка. Число строк первой матрицы не равно числу столбцов второй. ");
else 
{    
    int[,] firstMatrix = CreateMatrix(row1, collumns1);
    int[,] secondMatrix = CreateMatrix(row2, collumns2);

    PrintMatrix(firstMatrix);
    PrintMatrix(secondMatrix);

    int[,] resultMatrix = new int[row1, collumns2];

    Console.WriteLine($"Произведение матриц равно \n");
    MultMatrix(firstMatrix, secondMatrix, resultMatrix);
    PrintMatrix(resultMatrix);
}