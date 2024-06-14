// 4)  1 + 1/x + 1/x^2

Console.WriteLine("Введите переменную X:");
string X = Console.ReadLine();

double DoubleX; // Переменная X в типе с плавающей точкой, чтобы просиходило нормально деление

bool SuccessX; // Логическая переменная для проверки Х

SuccessX = double.TryParse(X, out DoubleX);

if (SuccessX) // Проверка Х на целочисленность
{
    if (DoubleX == 0)
    {
        Console.WriteLine("Деление на ноль невозможно!");
    }
    else
    {
        Console.WriteLine(1 + (1 / DoubleX) + 1 / Math.Pow(DoubleX, 2));
    }
    
}
else
{
    Console.WriteLine("Операция невозможна!");
}