// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void InputMatrix(double[,] matrix)
{
    Console.Write($"Минимальное значение элемента массива = ");
    double min = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Максимальное значение элемента массива = ");
    double max = Convert.ToDouble(Console.ReadLine());
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * (max - min) + min, 1);
            Console.Write($"{matrix[i, j]} \t"); // знак табуляции для более красивого вывода матрицы
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();
double[,] matrix = new double[size[0],size[1]];
InputMatrix(matrix);