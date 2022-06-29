// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

//   Console.Write("введите число1: ");
//     int num1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("введите число2: ");
//     int num2 = Convert.ToInt32(Console.ReadLine());
//     if (num1 > num2)
//       Console.WriteLine("max = " + num1);
//     else{
//       Console.WriteLine("max = " + num2);
//     }



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("введите число1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число3: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2 & num1 > num3) {
Console.WriteLine("max = " + num1);
}
else if (num2 > num3 & num2 > num1) {
Console.WriteLine("max = " + num2);
}
else {
    Console.WriteLine("max = " + num3);
}