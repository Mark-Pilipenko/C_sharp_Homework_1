Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N >= 0)
{
    Console.Write("Четные числа от 1 до " + N + ": ");
    for (int i = 1; i <=N ;i++)
    {
        if (i % 2 == 0) Console.Write(i + " ");
    }
}
else
{
    Console.Write("Четные числа от" + N + " до 1: ");
    for (int i = N; i <=1 ;i++)
    {
        if (i % 2 == 0) Console.Write(i + " ");
    } 
}