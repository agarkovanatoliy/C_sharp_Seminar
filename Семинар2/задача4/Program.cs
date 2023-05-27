// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно
// одновременно 7 и 23.

// Console.Write("Введите число: ");
// int number = int.Parse( Console.ReadLine());

// if (number % 7 == 0 & number % 23 == 0)
// {
//     Console.Write("Число кратно и 7 и 23!");
// }
// else
// {
//     Console.Write("Число не кратно и 7 и 23!");
// }

void Multiplicity( int arg)
{
    if (arg % 7 == 0 & arg % 23 == 0)    //& - это "И"; || - это "ИЛИ"
    {
        Console.Write("Число кратно и 7 и 23!");
    }
    else
    {
        Console.Write("Число не кратно и 7 и 23!");
    }
}

Console.Write("Введите число: ");
int number = int.Parse( Console.ReadLine());

Multiplicity( number );