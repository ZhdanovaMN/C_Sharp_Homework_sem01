Console.Write("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
int a = int.Parse(userInput1);

Console.Write("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int b = int.Parse(userInput2);

if (a > b)
{
    Console.Write("a = " + a + ", b = " + b + " -> max = ");
    Console.WriteLine(a);
}
else
{
    Console.Write("a = " + a + ", b = " + b + " -> max = ");
    Console.WriteLine(b);
}