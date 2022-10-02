Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int N = int.Parse(userInput);

Console.Write(N + " -> ");

int count = 1;
while (count <= N)
{
    if (count % 2 == 0)
    {
        //Console.Write(N);
        Console.Write(count + ", ");
    }
    count++;
}