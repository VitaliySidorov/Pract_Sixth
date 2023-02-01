// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
int num = ReadNumber();
int[] array = FillArray(num);
PrintArray(array);
NumberNaturalElements(array);

int ReadNumber() // Метод проверки ввода неотрицательного числа
{
    while (true)
    {
        Console.Write("Введите количество элементов массива:\t");
        if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
        {
            return number;
        }
        else Console.WriteLine("Не удалось распознать требуемое число, попробуйте еще раз.");
    }
}
int ReadIntegerNumber() // Метод проверки ввода целого числа
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            return number;
        }
        else Console.WriteLine("Не удалось распознать требуемое число, попробуйте еще раз.");
    }
}
int[] FillArray(int n) // Метод заполнения массива числами
{
    int[] arrayManual = new int[n];
    
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        arrayManual[i] = ReadIntegerNumber();
    }
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
    Console.Write("Исходный массив\t");
    Console.WriteLine($"[{String.Join(", ", array)}]");
}