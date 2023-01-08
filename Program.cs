//  Задача 1. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков
// System.Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// if (number.Length < 3)
// {
//     Console.WriteLine ("Ошибка,если число не состоит из трёх знаков");
// }
// else
// {
//     System.Console.WriteLine(number[1]);
// }

// Задача 2. Напишите программу,которая выводит третью цифру заданного числа или сообщает,что третьей цифры нет.
//Берем числа до 100000
// System.Console.WriteLine("Введите число:");
// string number = Console.ReadLine();
// if (number.Length < 3 )
// {
//     System.Console.WriteLine("Третьей цифры не существует");
// }
// else
// {
//       System.Console.WriteLine(number[2]);
// }
   
// Задача 3. Напишите программу,которая принимает на вход цифру,обозначающую день недели и проверяет, является ли этот день выходным.
//Обязательна проверка на ввод числа <1 и >7
// System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number  == 1)
{
    System.Console.WriteLine("Понедельник");
}
if (number ==  2)
{
    System.Console.WriteLine("Вторник");
}
if (number == 3)
{
    System.Console.WriteLine("Среда");
}
if (number == 4)
{
    System.Console.WriteLine("Четверг");
}
if (number == 5)
{
    System.Console.WriteLine("Пятница");
} 
if(number ==  6)
{
    System.Console.WriteLine("Суббота");
}
if (number ==  7)
{
    System.Console.WriteLine("Воскресенье");
}
    else if (number >= 1 && number <= 5)
{
  System.Console.WriteLine("Будний день");  
}
   else if (number >= 5 && number <= 7)
{
    System.Console.WriteLine("Выходной день");
}
