// Вид метода 4 - метод принимает аргументы, и что-то возвращает.
// string Method4(int count, string txt)
// {
//     int i = 0;
//    string result = String.Empty;
    
//    while (i < count)
//    {
//        result = result + txt;
//        i++;
//    }
//    return result;
// }
// string res = Method4(5, " abcdefg ");
// Console.WriteLine(res);


string Method5(int count, string txt) // Вид метода 5 - в отличии от метода 4 применяем метод с циклом for, тем самым код программы получается компактнее.
{
    string result = String.Empty;
    for ( int i = 0; i < count; i++)
    {
        result = result + txt;
    }
    return result;
}
string res = Method5(5, " abcdefg ");
Console.WriteLine(res);