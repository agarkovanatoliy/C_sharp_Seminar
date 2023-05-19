// Запросить 2 числа, и вывести является ли первое число квадратом второго!!

Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int numberB = int.Parse(Console.ReadLine());

int quad = numberB * numberB;

if (quad == numberA)
{
    Console.Write("Является ");
}
else
{
    Console.Write("Не является ");
}