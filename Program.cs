// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 


// Создааем массив типа char
// char[,] chars = {
//                 { 'a', 'b' },
//                 {  'e','c' },
//                 {  '4','f' }
//                 };

// // обьявили строку и создали ячейку памяти для хранине значений 
// string str = "";

// // обявили цикл foreach с неявной типизацией 
// foreach(var letters in chars)
// {
//     str += letters;
// }
// // Просим ввывести значение в терменал 
// System.Console.WriteLine(str);


// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные. 


// // Задаем строку с латинскими буквами в обоих регистрах
// string inputString = "HeLLo WoRLd";

// // Формируем новую строку с заменой заглавных букв на строчные
// string resultString = ConvertToUpperToLower(inputString);

// // Выводим результат
// Console.WriteLine($"Исходная строка: {inputString}");
// Console.WriteLine($"Результат: {resultString}");
    
// static string ConvertToUpperToLower(string input)
// {
//     char[] charArray = input.ToCharArray();

//     for (int i = 0; i < charArray.Length; i++)
//     {
//         if (char.IsUpper(charArray[i]))
//         {
//              charArray[i] = char.ToLower(charArray[i]);
//         }
//     }

//     return new string(charArray);
// }


// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом

string inputString = "довод";
bool isPalindrome = IsPalindrome(inputString);
Console.WriteLine($"Строка '{inputString}' является палиндромом: {isPalindrome}");


static bool IsPalindrome(string str)
{
    str = str.ToLower();
    for (int left = 0, right = str.Length - 1; left < right; left++, right--)
    {
        if (str[left] != str[right])
        {
            return false;
        }
        }
    return true;
}

