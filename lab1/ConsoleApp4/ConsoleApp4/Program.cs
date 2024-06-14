// (1) --m-n++

Console.WriteLine("Введите переменную n:");
string N = Console.ReadLine();

Console.WriteLine("Введите переменную m:");
string M = Console.ReadLine();

int IntN; //Переменная N в целочисленном типе
int IntM; // Переменная M в целочисленном типе

bool SuccessN = int.TryParse(N, out IntN); // Проверка переменной N
bool SuccessM = int.TryParse(M, out IntM); // Проверка переменной M

if (SuccessN && SuccessM) //Проверка на то, являются ли переменные целыми числами
{
    Console.WriteLine(--IntM - IntN++);
}
else
{
    Console.WriteLine("Операция невозможна при введённых значениях");
}



