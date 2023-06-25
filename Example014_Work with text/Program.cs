// Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить на маленькие "с"

// ПОНЯТНА ЛИ ЗАДАЧА?

string text = "- Я думаю, -сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вмесо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // это наш 3 символ r из строки

string Replace(string text, char oldValue, char newValue) //метод будет принимать данную строку и будет выдавать новую строку с заменой символов
{
    string result = String.Empty; // заводим новую строку, инициализация новой строки "String.Empty"
    
    int length = text.Length; // обращаемся к свойству, показывающему количество символов в строке
    for (int i = 0; i< length; i++) // воспользовавшись циклом for мы проверяем строку от первого символа i до конца length нашей строки
    {
        if(text[i] == oldValue) result = result + $"{newValue}"; // если текущий символ text[i] совпал с тем символом который мвы хотим заменить то в результат выводится строка с новым символом
        else result = result + $"{text[i]}"; // если же совпадений нет то в результате нужно оставить строку с текущим символом, без изменений
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();