// (2) m*m<n++

Console.WriteLine("Введите переменную n:");
string N = Console.ReadLine();

Console.WriteLine("Введите переменную m:");
string M = Console.ReadLine();

int IntN; //Переменная N в целочисленном типе
int IntM; // Переменная M в целочисленном типе

bool Result2; // Переменная результата будет логического типа, т.к пример является неравенством
bool SuccessN = int.TryParse(N, out IntN); // Проверка переменной N
bool SuccessM = int.TryParse(M, out IntM); // Проверка переменной M

if (SuccessN && SuccessM) //Проверка на то, являются ли переменные целыми числами 
{
    Result2 = IntM * IntM < IntN++; // Само неравенство
    if (Result2)
    {
        Console.WriteLine("Неравенство истинно.");
    }
    else
    {
        Console.WriteLine("Неравенство ложно.");
    }
 //   Console.WriteLine(Result2);
}
else
{
    Console.WriteLine("Невозможно решить неравенство!");
}

