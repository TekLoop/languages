Console.Clear();
Console.WriteLine("int first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("int second number");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("int third number");
int c = Convert.ToInt32(Console.ReadLine());

if (a == b && b == c)
Console.WriteLine("numbers are the same");

    if (a > b && a > c)
    {
        Console.WriteLine($"max = {a}");
    }
    else
    {
        if (b > a && b > c)
        {
            Console.WriteLine($"max = {b}");
        }
        else
        {
            Console.WriteLine($"max = {c}");
        }        
    }