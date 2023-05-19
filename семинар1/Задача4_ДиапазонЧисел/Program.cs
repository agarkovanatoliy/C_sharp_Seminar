// Ввести число "N" и вывести все целые числс в диапазоне то -N до +N

Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine());

int numberB = numberA * -1;
int temp = numberA;

if (numberA < 0)
{
    numberA = numberB;
    numberB = temp;
}
while(numberB <= numberA )
{
     Console.Write(numberB +", ");
     numberB ++;
}
   