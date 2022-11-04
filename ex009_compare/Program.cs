Console.Clear();
Console.WriteLine("введите число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int y = Convert.ToInt32(Console.ReadLine());
int c;

if (x > y) // можно через оператор или ||(if (x*x=y || y*y=x)); также есть оператор и &&
{
    c = x / y;
        if (c == y)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
}
else
{
    c = y /x;
    if (c == x)
    {
         Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}