// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

// показать вторую цифру трехзначного числа
// Random random = new Random();
// int num = random.Next(100, 1000);
// Console.WriteLine(num);
// int firstAndSecond = num / 10;
// int result = firstAndSecond % 10;
// Console.WriteLine(result);

// показать третью цифру любого числа если есть

// int userNum = int.Parse(Console.ReadLine());
// Console.WriteLine(userNum);
// int ThirdNum(int num)
// {
//     if (num < 100)
//     {
//         return -1;
//     }
//     else if (num < 1000)
//     {
//         return num % 10;
//     }
//     else
//     {
//         return ThirdNum(num / 10);
//     }
// }
// int result = ThirdNum(userNum);
// if (result == -1)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     Console.WriteLine($"Третьея цифра - {result}");
// }

// является ли день выходным

// bool isParsed = int.TryParse(Console.ReadLine(), out int usrDay);
// string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
// if (isParsed)
// {
//     if (usrDay > 0 & usrDay < 8)
//     {
//         Console.WriteLine(daysOfWeek[usrDay - 1]);
//     }
//     else
//     {
//         Console.WriteLine("В неделе всего 7 дней");
//     }
// }
// else
// {
//     Console.WriteLine("Введите число");
// }
