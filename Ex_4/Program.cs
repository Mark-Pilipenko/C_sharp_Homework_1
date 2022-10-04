Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите еще одно число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("И еще одно: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine("Максимальное значение: " + max);