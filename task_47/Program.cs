// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​ m = 3, n = 4.

double[,] GetRandomMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            matrix[i,j] = new Random().NextDouble() *10;
        }   
    }
    return matrix;
}
void PrintMatrix(double[,]matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            Console.Write($"{matrix[i, j]:f2}" + " | ");
        }
        Console.WriteLine();
    }
}
const int rows = 3;
const int columns = 4;

double[,] array = GetRandomMatrix(rows, columns);
PrintMatrix(array);
