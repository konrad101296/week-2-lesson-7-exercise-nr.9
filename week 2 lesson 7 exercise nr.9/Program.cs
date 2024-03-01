Console.WriteLine("podaj temperature:");
double temp = double.Parse(Console.ReadLine());

if (temp < 0)
{
    Console.WriteLine("cholernie pizdzi");
}
else if (temp >= 0 && temp < 10)
{
    Console.WriteLine("zimno");
}
else if (temp >= 10 && temp < 20)
{
    Console.WriteLine("chłodno");
}
else if (temp >= 20 && temp < 30)
{
    Console.WriteLine("w sam raz");
}
else if (temp >= 30 && temp < 40)
{
    Console.WriteLine("zaczyna byc słabo,bo goraco");
}
else if (temp >= 40)
{
    Console.WriteLine("a weź wyprowadzam się na Alaskę");
}