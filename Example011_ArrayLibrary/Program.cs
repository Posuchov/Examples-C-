Console.Clear();
void FillArray(int[] collection)  // void метод который ничего не возвращает //
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        // index = index + 1;
        index++; 
    }
}
void PrintArray(int[] col)  // void метод который ничего не возвращает //
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] array = new int[10]; // вводим массив array = создай новый массив в котором будет 10 элементов //
FillArray(array);
PrintArray(array);