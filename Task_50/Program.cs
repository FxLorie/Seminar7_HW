// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} \t"); // знак табуляции для более красивого вывода матрицы
        }
        Console.WriteLine();
    }
}

string FindElement(int[,] matrix, int i0, int j0)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == i0 && j == j0) return Convert.ToString(matrix[i, j]);
        }
    }
    return "Такого числа в массиве нет";
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.Write("Введите позицию искомого элемента: ");
int[] ij = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// Console.WriteLine(FindElement(matrix, ij[0], ij[1]));
if (ij[0]<matrix.GetLength(0) && ij[1]<matrix.GetLength(1))
Console.WriteLine(matrix[ij[0],ij[1]]);
else Console.WriteLine("Такого числа в массиве нет");