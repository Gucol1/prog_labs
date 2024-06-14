// задача 2

Console.WriteLine("Введите координату X точки :");
string X = Console.ReadLine();

Console.WriteLine("Введите координату Y точки :");
string Y = Console.ReadLine();

bool SuccessX; // Логическая перемена для проверки X
bool SuccessY; // Логическая перемена для проверки Y

int IntX; // Переменная из строки в число
int IntY; // Переменная из строки в число

SuccessX = int.TryParse(X, out IntX); // Проверка X
SuccessY = int.TryParse(Y, out IntY); // Проверка Y

if (SuccessX && SuccessY) // Проверка по типу данных
{
    if (IntX<=5 && IntX>=-5 && IntY<=5 && IntY >= -5 &&(Math.Pow(IntX, 2) + Math.Pow(IntY, 2) <= 25)) //Проверка на то, находится ли точка в правой окружности
    {
        if (Math.Pow(IntX,2)+ Math.Pow(IntY, 2) == 25) // Проверка по формуле X^2 + Y^2 = R^2
        {
            Console.WriteLine("Точка находится на границе одной из окружностей ");
        }
        else
        {
            Console.WriteLine("Точка находится внутри окружностей");
        }
                
    }
    else
    {
        if (IntX <= 0 && IntX >= -10 && IntY <= 5 && IntY >= -5 && (Math.Pow(IntX+5, 2) + Math.Pow(IntY, 2) <= 25)) // Проверка на нахождение в первой окружности
        {
            if (Math.Pow(IntX+5, 2) + Math.Pow(IntY, 2) == 25) // Проверка по формуле X^2 + Y^2 = R^2
            {
                Console.WriteLine("Точка находится на границе одной из окружностей ");
            }
            else
            {
                Console.WriteLine("Точка находится внутри окружностей");
            }
        }
        else
        {
            Console.WriteLine("Точка находится за пределами закрашенной области!");
        }
            
    }
}
else
{
    Console.WriteLine("Невозможно определить!");
}