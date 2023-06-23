// // Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
string number = Console.ReadLine()!;
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

double[]coordinatesA = new double[3];
System.Console.Write("Введите координаты точки X: ");
coordinatesA[0]= Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты точки Y: ");
coordinatesA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты точки Z: ");
coordinatesA[2] = Convert.ToInt32(Console.ReadLine());

double[] coordinatesB = new double[3];
System.Console.Write("Введите координаты второй точки X: ");
coordinatesB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты второй точки Y: ");
coordinatesB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты второй точки Z: ");
coordinatesB[2] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine (Math.Round(Math.Sqrt(Math.Pow(coordinatesB[0],2)-Math.Pow(coordinatesA[0],2)+Math.Pow(coordinatesB[1], 2) - Math.Pow(coordinatesA[1], 2)+Math.Pow(coordinatesB[2], 2) - Math.Pow(coordinatesA[2], 2)),2));


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите число");
int numberB = Convert.ToInt32(Console.ReadLine());
int i=1;
while(i<=numberB)
{
    System.Console.Write(Math.Pow(i,3)+ " ");
    i++;
}








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

// int[]coordinatesA = new int[2];
// System.Console.Write("Введите координаты точки X: ");
// coordinatesA[0]= Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите координаты точки Y: ");
// coordinatesA[1] = Convert.ToInt32(Console.ReadLine());

// int[] coordinatesB = new int[2];
// System.Console.Write("Введите координаты второй точки X: ");
// coordinatesB[0] = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите координаты второй точки Y: ");
// coordinatesB[1] = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(coordinatesB[0],2)-Math.Pow(coordinatesA[0],2)+Math.Pow(coordinatesB[1], 2) - Math.Pow(coordinatesA[1], 2)),2));


// лайфхак вводим строки превращаем в массив строк выводим как массив

// int[]array= Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse); // Parse=ToInt32
// for ( int i =0; i<array.Length; i++)
// {
//     System.Console.Write(array[i]+ " ");
// }

// //вывод в одну строку разделителей между цифрами
// int[]array1 = {12,-23,43,5};
// System.Console.WriteLine(string.Join("|| ",array1));

// // таблица кубов чисел от 1 до N
// System.Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int i=1;
// while(i<=number)
// {
//     System.Console.Write(Math.Pow(i,2)+ " ");
//     i++;
// }
