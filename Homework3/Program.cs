// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


// {
//             Console.Write("Введите число :");
//             string num = Console.ReadLine();
//             int len = num.Length;
//             bool flag = true;
 
        
//             for (int i = 0; i < len/2; i++)
//             {
//                 if (num[i] != num[len - (i + 1)])
//                 {
//                     flag = false;
//                     break;
//                 }
//             }
 
            
//             if (flag)
//             {
//                 Console.WriteLine("Палиндром");
//             }
//             else
//             {
//                 Console.WriteLine("Не палиндром");
//             }
//             Console.ReadLine();
//         }




// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// double SystemCoor(int x1, int y1, int z1, int x2, int y2, int z2){
//     return Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1- y2) + (z1 - z2)*(z1 - z2));
// }
//     Console.WriteLine("Введите координату х1");
//      int x1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координату y1");
//     int y1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координату z1");
//     int z1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координату х2");
//      int x2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координату y2");
//     int y2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координату z2");
//     int z2 = Convert.ToInt32(Console.ReadLine());

//  Console.WriteLine(SystemCoor(x1, y1, z1, x2, y2, z2));   
