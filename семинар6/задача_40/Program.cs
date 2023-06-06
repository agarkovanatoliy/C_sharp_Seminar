// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

void Comparison(int a, int b, int c)
{
    if(a < b+c && b < a+c && c < a+b) Console.WriteLine("Такой треугольник может быть!");
    else  Console.WriteLine("Такого треугольника не может быть!");
}

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int a = Prompt("Введите первое число:");
int b = Prompt("Введите второе число:");
int c = Prompt("Введите третье число:");
Comparison(a, b, c);

