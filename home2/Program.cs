// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

// char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
// string result = GetString(charArray);
// Console.WriteLine(result);
// string GetString(char[,] array)
// {
// string result = "";
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// result += array[i, j];
// }
// }
// return result;
// }

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.


// string input = "jfkG!Dk5fEu";
// string result = input.ToLower();
// Console.WriteLine(result);

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.


string input = "казак";
bool isPalindrome = IsPalindrome(input);
Console.WriteLine(isPalindrome ? "Да" : "Нет");
 bool IsPalindrome(string str)
{
string norm = new
string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
return norm.SequenceEqual(norm.Reverse());
}

// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.