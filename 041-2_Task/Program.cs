// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
int[] array = FillArray();
PrintArray(array);
NumberNaturalElements(array);

int[] FillArray() // Метод заполнения массива числами
{
    Console.Write("Задайте массив чисел [Enter - конец ввода]: ");
    char[] separators = new char[] { ' ', ',', '.', ':', ';', '|', '/' }; // Возможные разделители ввода
    var numbers = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(token => int.Parse(token));
    int[] arrayManual = numbers.ToArray();
    return arrayManual;
}
void NumberNaturalElements(int[] arr) // Метод поиска количества натуральных чисел в массиве
{
    int countNatural = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) countNatural ++;
    }
    Console.WriteLine($"Количество элементов массива больше 0 равно {countNatural}");
}
void PrintArray(int[] array) // Метод вывода массива в консоль
{
    Console.Write("Заданный массив\t");
    Console.WriteLine($"[{String.Join(", ", array)}]");
}