// Ввести трехзначное число и вывести последнюю цифру

Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine());
int result = numberA % 10;
Console.WriteLine(result);
