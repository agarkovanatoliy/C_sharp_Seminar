// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// Console.Write("Введите первое число: ");
// int number1 = int.Parse( Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = int.Parse( Console.ReadLine());

// if (number1 % number2 == 0)
// {
//     Console.WriteLine("Числа кратные!");
// }
// else
// {
//     Console.Write("Числа не кратные! Остаток: " + number1 % number2);
// }

void Multiplicity(int arg1, int arg2)
{
    if (arg1 % arg2 == 0)
    {
        Console.WriteLine("Числа кратные!");
    }
    else
    {
        Console.Write("Числа не кратные! Остаток: " + arg1 % arg2);
    }

}

Console.Write("Введите первое число: ");
int number1 = int.Parse( Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse( Console.ReadLine());

Multiplicity(number1, number2);