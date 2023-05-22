// найти максимум из 9 чисел с помощью функции и массива

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result; // retrn возвращает результат работы функции
}

int[] array={11, 21, 31, 451, 56, 63, 17, 18, 19};

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));


Console.WriteLine(max);