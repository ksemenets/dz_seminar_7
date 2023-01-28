// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// ​1 4 7 2
// ​5 9 2 3
// ​8 4 2 4
// ​1 7 -> такого числа в массиве нет

int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,]matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i ++)
    {
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            Console.Write(matrix[i, j] + " | ");
        }
        Console.WriteLine();
    }
}
const int rows = 4;
const int columns = 4;
const int leftRange = 10;
const int rightRange = 100;

int[,] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrintMatrix(array);

Console.WriteLine("Введите номер строки");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int b = Convert.ToInt32(Console.ReadLine());

if (a > array.GetLength(0) || b > array.GetLength(1))
Console.WriteLine ("Элемента с таким адресом в этом массиве нет!");
 else
 Console.WriteLine(array[a - 1, b - 1]);
