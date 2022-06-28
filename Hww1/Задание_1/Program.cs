// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int min;
int max;


if(number1 < number2)
{
    min = number1;
    max = number2;
}
else
{
    min = number2;
    max = number1;
}
Console.WriteLine("Максимальное число" + max);
Console.WriteLine("Минимальное число" + min);
