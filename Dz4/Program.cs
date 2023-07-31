/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


int InputMessage(string message)
{
    Console.Write(message);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k}) \t");
            }
            Console.WriteLine();
        }
    }
}



void CreateMatrix(int[,,] matrix)
{
    int[] temp = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    int numb;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        numb = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                temp[j] = new Random().Next(10, 100);   
                while (temp[i] == temp[j])
                {
                    temp[j] = new Random().Next(10, 100);
                    j = 0;
                    numb = temp[i];
                }
                numb = temp[i];
            }
        }
    }
    int count = 0; 
    for (int x = 0; x < matrix.GetLength(0); x++)
    {
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[x, y, z] = temp[count];
                count++;
            }
        }
    }  
}


int n1 = InputMessage("Введите X: ");
int n2 = InputMessage("Введите Y: ");
int n3 = InputMessage("Введите Z: ");
Console.WriteLine();

int[,,] matrix = new int[n1, n2, n3];
CreateMatrix(matrix);
PrintMatrix(matrix);