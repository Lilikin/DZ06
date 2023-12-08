// Задача 2: 
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// произвольная строчка
// Console.Write("Введите строчку: ");
// string inputString = Console.ReadLine();
// inputString = inputString.ToLower();
// Console.Write("Полученная строчка: " + inputString);

//Заданная строчка
string text = "HelLO mY WoRld!";
Console.WriteLine("\nИзначальная строчка: " + text);
text = text.ToLower();
Console.WriteLine($"\nПолученная строчка: {text}");
