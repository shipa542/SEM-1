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


// Console.Write("введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (num > 0)
// {
//     int i = num % 10;
//     num = num / 10;
//     sum = sum + i;
// }

// Console.WriteLine("Сумма всех цифр в числе равна: " + sum);





// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]




// int[] num = new int[8];
// Console.Write("[");

// for (int  i = 0;  i < num.Length; i++)
// {
//     num [i] = new Random().Next(0, 11);
//     Console.Write(" "+ Massiv (i) + ","+" ");
// }
// Console.Write("]");

//  int Massiv (int N)
//  {
//     return num[N];
//  }

// Второе решение задачи=)

// int[] CreateRandomArray(int start, int end)
// {
//     int[] RandomArray = new int[8];
//     for (int i = 0; i < 8; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end +1);
//         Console.Write(RandomArray[i] +",");
//     }
//     return RandomArray;
// }

//  void ShowArray(int[] array)
//  {  Console.Write(" -> [");
//    for (int i = 0; i < array.Length; i++)
//    {
//     Console.Write(array[i] + ",");
//    } 
//    Console.Write("]");
//    Console.WriteLine();
//  }


//  Console.Write("Введите первое число случайно генерируемого диапазона:");
//  int min = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите последнее число случайно генерируемого диапазона:");
//  int max = Convert.ToInt32(Console.ReadLine());

// int[] MyRandomArray = CreateRandomArray(min, max);
// ShowArray(MyRandomArray);
