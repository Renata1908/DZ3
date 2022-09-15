Console.WriteLine("Введите координату точки А: х1");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки А: у1");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки А: z1");
double z1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координату точки В: х2");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки В: у2");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки А: z2");
double z2 = Convert.ToInt32(Console.ReadLine());


double res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"{res:f2}");
