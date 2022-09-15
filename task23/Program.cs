Console.WriteLine("Введите число N(N > 0):");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write(i * i * i + " ");
    }
}
else
{
    Console.WriteLine("N должно быть больше 0!");
}
