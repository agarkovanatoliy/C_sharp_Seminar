//Нписать программу, которая выдает случайное число из отрезка (10, 99) и показывает наибольшую цифру числа

// int number = new Random().Next(10, 100);
// int firstNumber = number / 10;
// int secondNumber = number % 10;
// Console.WriteLine("Рандомное число: " + number);
// Console.WriteLine( firstNumber);
// Console.WriteLine( secondNumber);

// if (firstNumber > secondNumber)
// {
//     Console.WriteLine("Первая цифра больше второй!");
// }
// else if (secondNumber > firstNumber)
// {
//     Console.WriteLine("Вторая цифра больше первой!");
// }
// else
// {
//     Console.WriteLine("Цифры равны");
// }


int FindFirstDigit( int arg) //метод определения перрвой цифры двухзначного числа
{
    int firstNumber = arg / 10;
    return firstNumber;
}

int FindSecondDigit( int arg)   //метод определения второй цифры двухзначного числа
{
    int secondNumber = arg % 10;
    return secondNumber;
}

void FindLargestDigit(int arg, int arg1, int arg2)   //метод определения какая из цифр больше
{
    Console.WriteLine("Рандомное число: " + arg);    
    Console.WriteLine( arg1 );
    Console.WriteLine( arg2 );

    if ( arg1 > arg2 )
    {
        Console.WriteLine("Первая цифра больше второй!");
    }
    else if (arg2 >arg1 )
    {
        Console.WriteLine("Вторая цифра больше первой!");
    }
    else
    {
        Console.WriteLine("Цифры равны");
    }
}

int number = new Random().Next(10, 100);
int firstNumber = FindFirstDigit( number );
int secondNumber = FindSecondDigit( number );
FindLargestDigit(number, firstNumber,secondNumber);

int number1 = new Random().Next(10, 100);
int firstNumber1 = FindFirstDigit( number1 );
int secondNumber1 = FindSecondDigit( number1 );
FindLargestDigit(number1, firstNumber1, secondNumber1);

int number2 = new Random().Next(10, 100);
FindLargestDigit(number2, FindFirstDigit( number2 ), FindSecondDigit( number2 ));