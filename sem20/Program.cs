int x = new Random().Next (100, 1000);
Console.WriteLine (x);
int a = x/100;
int b = x%10;
int c = a *10 + b;
Console.WriteLine ($"{a}{b}");
Console.WriteLine (c);
Console.WriteLine ($"{Convert.ToString(x)[0]}{Convert.ToString(x)[2]}");