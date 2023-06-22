// // Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

// int[] coordinates = new int(3); // три точки
// System.Console.Write("Введите координату Х: ");
// coordinates[0] = Convert.ToInt32(Console.ReadLine()); // записывает данные в 1 ячейку

// System.Console.Write("Введите координату Y: ");
// coordinates[1] = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите координату Z: ");
// coordinates[2] = Convert.ToInt32(Console.ReadLine());

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Программа приимает значения двух точек кординат и показывает в какой четверти нахолится точка

// int[] coordinates = new int[2]; // две точки
// System.Console.Write("Введите координату Х: ");
// coordinates[0] = Convert.ToInt32(Console.ReadLine()); // записывает данные в 1 ячейку

// System.Console.Write("Введите координату Y: ");
// coordinates[1] = Convert.ToInt32(Console.ReadLine());

// if(coordinates[0]> 0 && coordinates[1] > 0)
// {
//     System.Console.WriteLine("Точка находится в первой четверти");
// }
// else if(coordinates[0] <0 && coordinates[1] > 0)
// {
//     System.Console.WriteLine("Точка находится во 2 четверти");
// }
// else if (coordinates[0] < 0 && coordinates[1] < 0)
// {
//     System.Console.WriteLine("Точка находится в 3 четверти");
// }
// else if (coordinates[0] > 0 && coordinates[1] < 0)
// {
//     System.Console.WriteLine("Точка находится во 4 четверти");
// }
// else
// {
//     System.Console.WriteLine("Неправильно ввели координаты");
// };


// Программа для определения возможных координат по четверти
// System.Console.WriteLine("Введите номер четверти");
// int number = Convert.ToInt32(Console.ReadLine());
// string[] coord = { "X>0, Y>0", "X<0,Y>0", "X<0,Y<0", "X>0,Y<0" }; // через массив поиск по индексу
// if (number > 0 && number < 5)
// {
//     System.Console.WriteLine(coord[number - 1]); //потому что в массиве -1 колучаем координаты четверти
// }
// else
// {
//     System.Console.WriteLine("Такой четверти не существует");
// }


// System.Console.WriteLine(Math.Pow(3,5)); // возведение 3 в степень 5
// System.Console.WriteLine(Math.Sqrt(9));// квадратный корень 9
// double temp = Math.Sqrt(12);
// System.Console.WriteLine(temp);
// System.Console.WriteLine(Math.Round(temp,3)); // округление до 3 знака


//вводим координаты двух точек и нахолим расстояние между ними

int[]coordinatesA = new int[2];
System.Console.Write("Введите координаты точки X: ");
coordinatesA[0]= Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты точки Y: ");
coordinatesA[1] = Convert.ToInt32(Console.ReadLine());

int[] coordinatesB = new int[2];
System.Console.Write("Введите координаты второй точки X: ");
coordinatesB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты второй точки Y: ");
coordinatesB[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(coordinatesB[0],2)-Math.Pow(coordinatesA[0],2)+Math.Pow(coordinatesB[1], 2) - Math.Pow(coordinatesA[1], 2)),2));
