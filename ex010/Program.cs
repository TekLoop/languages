Console.Clear();
Console.WriteLine("int first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("int second number");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
Console.WriteLine("numbers are the same");
    if (a > b)
    {
        Console.WriteLine($"max = {a}");
    }
    else
    {
        Console.WriteLine($"max = {b}");
    }