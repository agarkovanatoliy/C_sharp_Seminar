// Поиск элемента массива с использованием методов

// Метод заполнения массива рандомными числами в диапазоне от 1 до 10

void FillArray(int[] collection)   // Void - метод которй ничего не возвращает
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index ++;
    }
}

// Метод печати массива

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position ++;
    }
}

// Функция поиска позиции в массиве

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while ( index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index ++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf( array, 4);
Console.WriteLine(pos);