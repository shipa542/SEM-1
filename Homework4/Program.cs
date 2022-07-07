// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16




// Console.Write("введите число А: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите число В: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int step = num1;

// for (int i = 1; i < num2; i++)
// {
//     step = step * num1;
// }
// Console.WriteLine("А в степени В равно: " + step);




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (num > 0)
{
    int i = num % 10;
    num = num / 10;
    sum = sum + i;
}

Console.WriteLine("Сумма всех цифр в числе равна: " + sum);









