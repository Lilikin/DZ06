// Задача 3: 
// Задайте произвольную строку. Выясните, является ли она палиндромом.

Console.Write("Введите строчку: ");
string inputString = Console.ReadLine();
inputString = inputString.ToLower();
inputString = inputString.Replace(" ", "");
string reternString = new string(inputString.Reverse().ToArray());
if (inputString == reternString)
{
    Console.Write("Это палиндром");
}
else
{
    Console.Write("Это не палиндром");
}
