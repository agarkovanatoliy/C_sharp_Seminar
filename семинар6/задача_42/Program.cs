// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int Input()
{
    Console.Write("Введите: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

//решение с помощью массива математически

// int[] Solution(int num)
// {
//     int[] res = new int[] {};
//     int i = 0;
//     while (num > 0)
//     {   
//         Array.Resize(ref res, res.Length + 1);    
//         res[i] = num % 2;
//         num = num /2;
//         i++;    
//     }
//     return res;
// }
// int[] ReverseArray2(int[] inArray)
// {
//     int[] res = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         res[i] = inArray[inArray.Length - 1 - i];
//         Console.Write($"{res[i]}");
//     }
//     return res;
// }
// int num1 = Input();
// int[] newArray = Solution(num1);
// ReverseArray2(newArray);



// решениу с помощью строки
void Convert10To2(int num)
{
    int res = 0;
    string showresult = string.Empty;
    while (num > 0)
    {
        res = num % 2;
        num /= 2;
        showresult = res + showresult; // 0 + "пустое значени" // 0+0 // 0+00 // 1+000//
    }
    Console.WriteLine();
    Console.WriteLine(showresult);

}

// int a = Input();
// Convert10To2 (a);


// решение с помощью втроенных функций

int a = Input();
string res1=Convert.ToString(a,2);
Console.WriteLine(res1);