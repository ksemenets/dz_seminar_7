// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// ​Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
const int rows = 5;
const int columns = 6;
const int leftRange = 1;
const int rightRange = 100;

int[,] array = GetRandomMatrix(rows, columns, leftRange, rightRange);
PrintMatrix(array);

double[] GetNewArray(int[ , ]array) 
{
double[] newarray = new Double[array.GetLength(1)];

for(int j = 0; j < array.GetLength(1); j ++)
    {
        for(int i = 0; i < array.GetLength(0); i ++)
        {            
            newarray[j] = (newarray[j] + array[i, j] / Convert.ToDouble(array.GetLength(0)));
        }        
    }
    return newarray;
}
Console.WriteLine("Ниже приведены среднеарифметические по каждому из столбцов");
Console.WriteLine(String.Join(" | ", GetNewArray(array)));
//Вывод результата не совсем такой как в условии, но зато
// мой "метод" более универсален, как мне кажется) Он позволяет
// получить ср. арифметич. не только в матрице с заранее известными параметрами,
// но и из любой размерности которую получит на вход. 