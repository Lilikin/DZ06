// Задача 1: 
// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

string StringFromCharArrayBivariate(char[,] array)
{
    string result = String.Empty;
    foreach (var symbol in array)
    {
        result = result + symbol;
    }
    return result;
}

char[,] chars = {
    { 'H', 'e', 'l', 'l', 'о', ' ' },
    { 'W', 'o', 'r', 'l', 'd', '!'},
};

string result = StringFromCharArrayBivariate(chars);
Console.WriteLine($"Result: {result}");
