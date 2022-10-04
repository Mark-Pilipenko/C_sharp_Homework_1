Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите еще одно число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Большее число: " + a);
}
else if (a < b)
{
    Console.WriteLine("Большее число: " + b);
}
else
{
    Console.WriteLine("Числа равны: " + a);
}