//Получить число от пользователя и вывести квадрат этого числа

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());   // int.Parse - команда переводит строковое значение - в числовое
int result = number * number;
Console.WriteLine(result);