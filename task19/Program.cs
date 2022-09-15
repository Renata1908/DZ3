Console.WriteLine("Введите пятизначное число:");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 9999 && n < 100000)
{

if ((n / 10000) == (n % 10) && (n / 1000 % 10) == ((n % 100) / 10))
{
Console.WriteLine("Число является палиндромом");
}
else
{
Console.WriteLine("Число не является палиндромом");
}
}
else
{
Console.WriteLine("Введено некорректное число!");
}
