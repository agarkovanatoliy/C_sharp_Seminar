// Задача 48 Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
// Aₙₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Clear();

int Prompt(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
}

void PrintMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int colum = 0; colum < matrix.GetLength(1); colum++)
        {
            Console.Write($" {matrix[row, colum]}");
        }
        Console.WriteLine();
    }
}

int[,] CreateMRandoMatrix(int rows, int colums)
{
    int[,] matr = new int[rows, colums];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
        }
    }
    return matr;
}

int i = Prompt("Ведите количество строк массива: ");
int j = Prompt("Введите количество столбцов массива: ");
int[,] matr = CreateMRandoMatrix(i, j);
PrintMatrix(matr);
