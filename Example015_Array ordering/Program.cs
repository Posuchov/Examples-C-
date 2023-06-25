// Работа с массивом. Метод упорядывачивания данных внутри массива, алгоритм сортировки методом min-max
Console.Clear(); // очищаем терминал
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1}; // запись массива который надо отсортировать (с повторяющимися-одинаковыми элементами)

void PrintArray(int[] array) // метод "void" вывода массива на экран
{
    int count = array.Length; // получение кол-ва элементов массива
   
    for (int i = 0; i < count; i++) // в этом цикле мы перебираем все элементы массива
   {
       Console.Write($"{array[i]} "); // вывод на экран элементов массива в одну строку
   }
   Console.WriteLine(); // после вывода элементов в строку происходит отделение дополнительной пустой строкой
}

void SelectionSort(int[] array) // пишем метод упорядочивания-сортировки массива, в качестве аргумента массив array
{
    for (int i = 0; i < array.Length - 1; i++) // в этом цикле мы перебираем все элементы массива, есть особенность
    {
        int minPosition = i; // определяем min-позицию и запоминаем позицию элемента для которого в дальнейшем будут производиться действия сравнения 
        for (int j = i+1; j < array.Length; j++) // ищем минимальный элемент массива
        {
            if(array[j] < array[minPosition]) minPosition = j;

        }
        
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);