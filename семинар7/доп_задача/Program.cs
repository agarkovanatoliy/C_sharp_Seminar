//  доп задача  задать 2 двумерных массива,
// и написать метод который перемножает поэлементно эти
// массивы и записывает значения в третий массив


Console.Clear();

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0 ; i < matrix.GetLength(0) ; i ++)
    {
        for (int j = 0 ; j<matrix.GetLength(1) ; j ++)
        {
            Console.Write($" {matrix [i , j]}");
        }
    Console.WriteLine();
    }
}

int[,] CreateMRandoMatrix (int rows , int colums , int from , int to)
{
    int [,] matrix = new int[rows,colums];
    to ++;
    for (int i = 0 ; i < matrix.GetLength(0) ; i ++)
    {
        for (int j = 0 ; j<matrix.GetLength(1) ; j ++)
        {
            matrix[i,j] = new Random().Next(from,to);
        }
    }
    return matrix;
}

int[,] MultuMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int [matrix1.GetLength(0),matrix1.GetLength(1)];

    for (int i = 0 ; i < result.GetLength(0) ; i ++)
    {
        for (int j = 0 ; j<result.GetLength(1) ; j ++)
        {
            result[i,j]=matrix1[i,j]*matrix2[i,j];
        }
    }
    return result;
}

int row = Prompt("Ведите количество строк массивов: ");
int col = Prompt("Введите количество столбцов массивов: ");
int from1 = Prompt("Введите начально значение элементов 1 массива: ");
int to1 = Prompt("Введите конечное значение элементов 1 массива: ");
int from2 = Prompt("Введите начально значение элементов 2 массива: ");
int to2 = Prompt("Введите конечное значение элементов 2 массива: ");
int[,] matr1 = CreateMRandoMatrix(row,col,from1,to1);
int[,] matr2 = CreateMRandoMatrix(row,col,from2,to2);
int[,] result = MultuMatrix(matr1, matr2);
PrintMatrix(matr1);
Console.WriteLine();
PrintMatrix(matr2);
Console.WriteLine();
PrintMatrix(result);
