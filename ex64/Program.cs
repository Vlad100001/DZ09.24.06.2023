//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
void Natural(int a, int count)
{
    if (count > a)
    {
        return;
    }
    else
    {
 Natural(a, count + 1);
 Console.Write(count + " ");
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
Natural(number, count);