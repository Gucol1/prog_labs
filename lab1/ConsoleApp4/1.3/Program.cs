//3) n-- > ++m

Console.WriteLine("Введите переменную n:");
string N = Console.ReadLine();

Console.WriteLine("Введите переменную m:");
string M = Console.ReadLine();

int IntN; //Переменная N в целочисленном типе
int IntM; // Переменная M в целочисленном типе

bool Result3; // Переменная результата будет логического типа, т.к пример является неравенством
bool SuccessN = int.TryParse(N, out IntN); // Проверка переменной N
bool SuccessM = int.TryParse(M, out IntM); // Проверка переменной M

if (SuccessN && SuccessM) //Проверка на то, являются ли переменные целыми числами 
{
    Result3 = IntN-- > ++IntM; // Само неравенство
    if (Result3)
    {
        Console.WriteLine("Неравенство истинно.");
    }
    else
    {
        Console.WriteLine("Неравенство ложно.");
    }
}
else
{
    Console.WriteLine("Невозможно решить неравенство!");
}

