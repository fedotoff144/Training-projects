// Control task
/*
Написать программу, которая из имеющегося массива строк формирует
массив строк, длина которых меньше либо равна 3 символа. Первоначальный
массив можно ввести с клавиатуры, либо задать на старте
выпоолнения алгоритма. При решении не рекомендуется пользоваться
коллекциями, лучше обойтись исключительно массивами.
Например:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

//Вводим значения первичного массива

Console.WriteLine("Введите значаения строчного массива");

Console.WriteLine("Введите значаение 1 элемента массива: ");
string? a = Console.ReadLine();
Console.WriteLine("Введите значаение 2 элемента массива: ");
string? b = Console.ReadLine();
Console.WriteLine("Введите значаение 3 элемента массива: ");
string? c = Console.ReadLine();
Console.WriteLine("Введите значаение 4 элемента массива: ");
string? d = Console.ReadLine();

//Для наглядности выводим исходный массив

string[] arr = { a, b, c, d };
Console.WriteLine("Исходный массив");
Console.WriteLine("[" + string.Join(", ", arr) + "]");

//Создаем дополнительный массив в который далее будем записывать значения длиной 3 и менее символов

string[] newArr = new string[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        Array.Resize(ref newArr, newArr.Length + 1);
        newArr[newArr.Length - 1] = arr[i];
    }
}

//Проверяем дополнительный массив на нулевое значение для соответствующего вывода

if (newArr.Length != 0)
{
    Console.WriteLine("Конечный массив");
    Console.Write("[" + string.Join(", ", newArr) + "]");
}
else
    Console.WriteLine("В массиве отсутствуют элементы длиной 3 и менее символов");

