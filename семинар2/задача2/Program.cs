// Написать программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа

// int number = new Random().Next(100, 1000);
// int firstNumber = number / 100;
// int secondNumber = number % 10;
// Console.WriteLine("Рандомное число: " + number);
// Console.WriteLine( firstNumber);
// Console.WriteLine( secondNumber);

// int result = firstNumber * 10 + secondNumber;
// Console.WriteLine("Полученное число: " + result);

int FindFirstDigit( int arg) //метод определения перрвой цифры трехзначного числа
{
    int firstNumber = arg / 100;
    return firstNumber;
}

int FindSecondDigit( int arg)   //метод определения последней цифры числа
{
    int secondNumber = arg % 10;
    return secondNumber;
}
void DoubleNumber(int arg, int arg1, int arg2)
{
    Console.WriteLine("Рандомное число: " + arg);
    Console.WriteLine("Первое число: " + arg1);
    Console.WriteLine("Третье число: " + arg2);

    int result = arg1 * 10 + arg2;
    Console.WriteLine("Полученное число: " + result);
}

int number = new Random().Next(100, 1000);
DoubleNumber(number, FindFirstDigit(number), FindSecondDigit(number));
