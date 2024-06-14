// ((a-b)^3 - (a^3 -3*(a^2)*b)) / 3*a*(b^2) - b^3

float a = 1000f;
float b =0.0001f;

double DoubleA = 1000;
double DoubleB = 0.0001;

Console.WriteLine("a и b - float");
Console.WriteLine((Math.Pow(a - b, 3) - (Math.Pow(a, 3) - 3 * Math.Pow(a, 2) * b)) / (3 * a * Math.Pow(b, 2) - Math.Pow(b, 3)));
Console.WriteLine();

Console.WriteLine("a - float , b - double");
Console.WriteLine((Math.Pow(a - DoubleB, 3) - (Math.Pow(a, 3) - 3 * Math.Pow(a, 2) * DoubleB)) / (3 * a * Math.Pow(DoubleB, 2) - Math.Pow(DoubleB, 3)));
Console.WriteLine();

Console.WriteLine("a - double, b - float");
Console.WriteLine((Math.Pow(DoubleA - b, 3) - (Math.Pow(DoubleA, 3) - 3 * Math.Pow(DoubleA, 2) * b)) / (3 * DoubleA * Math.Pow(b, 2) - Math.Pow(b, 3)));
Console.WriteLine();

Console.WriteLine("a, b - double");
Console.WriteLine((Math.Pow(DoubleA - DoubleB, 3) - (Math.Pow(DoubleA, 3) - 3 * Math.Pow(DoubleA, 2) * DoubleB)) / (3 * DoubleA * Math.Pow(DoubleB, 2) - Math.Pow(DoubleB, 3)));
Console.WriteLine();

Console.WriteLine("Результаты получаются очень разными, потому что тип Double имеет удвоенную точность по сравнению с типом Float, из-за этого появляютися разные ответы на один пример");