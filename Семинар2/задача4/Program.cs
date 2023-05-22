// Поиск элемента массива

int[] array = {1, 12, 31, 4, 15, 16, 17, 18};
int n = array.Length;                        // определяет длину массива
int find = 16;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;                      // Принудительно завершает работу после нахождения первого элемента
    }
    index ++;
} 

