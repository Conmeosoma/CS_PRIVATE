// 2 for bai toan kinh di :)\

Console.Write("Nhap n: ");
int n = int.Parse(Console.ReadLine());
// Console.WriteLine("     1");
for (int i = 1; i < n; i++)
{
    for (int j = 1; j < n - i; j++)
    {
        Console.Write(" ");
    }

    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);
    }
    for (int j = i - 1; j >= 1; j--)
    {
        Console.Write(j);
    }

    Console.WriteLine();
}