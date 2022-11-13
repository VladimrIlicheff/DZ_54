// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
//1 4 7 2   ----->  7 4 2 1
// 5 9 2 3  ----->  9 5 3 2
// 8 4 2 4  ----->  8 4 4 2

int[,] InitMatrix(int m, int n)
{
    int[,] resMtrx = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            resMtrx [i, j] = rnd.Next(0, 99);
        }
    }
    return resMtrx;
}

void PrintMtrx(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}    ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int GetMtrxSize(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void SortRowToLower(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int x = 0; x < matrix.GetLength(1) - 1; x++)
            {
                if (matrix[i, x] < matrix[i, x+1])
                {
                    int temp = matrix[i, x+1];
                    matrix[i, x+1] = matrix[i, x];
                    matrix[i, x] = temp;
                }
            }
        }
    }
}

int m = GetMtrxSize("Введите количество строк:");
int n = GetMtrxSize("Введите количество столбцов:");
int[,] initialMtrx = InitMatrix(m, n);
Console.WriteLine("Исходная матрица:");
PrintMtrx(initialMtrx);
SortRowToLower(initialMtrx);
Console.WriteLine();
PrintMtrx(initialMtrx);