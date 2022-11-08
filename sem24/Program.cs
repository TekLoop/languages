Console.WriteLine("введи сколько денег положил");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введи годовой процент");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введи сколько денег хочешь"); // и я скажу тебе сколько лет нужно подождать
int y = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (x <= y)
{
    x = x + x * p/100;
    count++;
}
Console.WriteLine(count);