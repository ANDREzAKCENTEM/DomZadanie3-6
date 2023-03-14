// Урок 6. Одномерные массивы. Продолжение
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите количество вводимых чисел : ");

// int elementsCount = int.Parse(Console.ReadLine());

// int[] array = new int[elementsCount];

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"\nВведите число №{i + 1}:\t");
//     array[i] = int.Parse(Console.ReadLine());
// }

// Console.WriteLine();

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i]);
//     Console.Write(',');
// }
// Console.Write("(чисел больше 0)->");

// int sum = default;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         sum++;
//     }
// }
// Console.WriteLine(sum);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух 
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите значения прямой 1: ");
// Console.Write("b1= "); int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("k1= "); int k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значения для прямой 2: ");
// Console.Write("b2= "); int b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("k2= "); int k2 = Convert.ToInt32(Console.ReadLine());

// double points = PointsLine(b1, k1, b2, k2);
// double pointsRound = Math.Round(points, 1);
// double PointsLine(double b1, double k1, double b2, double k2)
// {
//     {
//         double x = Math.Round((b1 - b2), 1) / Math.Round((k2 - k1), 1);
//         double y = Math.Round((k1 * x + b1), 1);
//         Console.WriteLine($"-> ({x} ;{y}) ");
//         if (k1 == k2)
//         {
//             Console.WriteLine(" прямые параллельны ");
//         }
//     }
//     return 0;
// }