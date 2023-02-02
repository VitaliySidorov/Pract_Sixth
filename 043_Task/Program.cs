// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Программа нахождения точки пересечения двух прямых, заданных линейной функцией вида y=kx+b.");
Console.Write("Введите коэффициент k 1-й прямой:\t");
int numK1 = ReadNumber();
Console.Write("Введите коэффициент b 1-й прямой:\t");
int numB1 = ReadNumber();
Console.Write("Введите коэффициент k 2-й прямой:\t");
int numK2 = ReadNumber();
Console.Write("Введите коэффициент b 2-й прямой:\t");
int numB2 = ReadNumber();

PresentLines(numK1, numB1, numK2, numB2);

KramerMethod(numK1, numB1, numK2, numB2);

void KramerMethod(int k1, int b1, int k2, int b2) // Используем метод Крамера решения систем линейных уравнений
{
    if (k1 != k2 && b1 != b2)
    {
        int determinant = -k1 + k2;
        if (determinant != 0)
        {
            double pointX = (double)(b1 - b2) / determinant;
            double pointY = (double)(k1 * (-b2) - k2 * (-b1)) / determinant;
            Console.WriteLine(string.Format("Прямые пересекаются в точке с координатами ({0:0.##}; {1:0.##})", pointX, pointY));
        }
        else Console.WriteLine($"Прямые не пересекаются.");
    }
    else Console.WriteLine("Прямые совпадают.");
}

void PresentLines(int k1, int b1, int k2, int b2) // Метод для вывода в консоль уравнения прямых с отработкой знаков
{
    string strK1 = k1.ToString() + "x";
    string strK2 = k2.ToString() + "x";
    string strB1 = b1.ToString();
    string strB2 = b2.ToString();
    if (b1 > 0) strB1 = "+" + b1.ToString();
    if (b2 > 0) strB2 = "+" + b2.ToString();
    if (b1 == 0) strB1 = "";
    if (b2 == 0) strB2 = "";
    if (k1 == 0) strK1 = "";
    if (k2 == 0) strK2 = "";
    Console.WriteLine(string.Format("Первая прямая:\t y={0}{1}", strK1, strB1));
    Console.WriteLine(string.Format("Вторая прямая:\t y={0}{1}", strK2, strB2));
}

int ReadNumber() // Метод проверки ввода числа
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