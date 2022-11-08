Console.WriteLine("Введи исходное количество км");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введи нужное количество км");
int y = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (x <= y)
{
    x = x * 1.15;
    count++;
}
Console.WriteLine(count);
