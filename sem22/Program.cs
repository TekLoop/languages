Console.WriteLine ("введи число");
int a = Convert.ToInt32(Console.ReadLine());

//    if (a > 99)
//  Console.WriteLine(Convert.ToString(a)[2]);
//    else
//    Console.WriteLine("третьей цифры нет");

if (a >= 1 && a <= 7 )
{
    if (a ==6 || a ==7)
    Console.WriteLine("выходной");
    else
    Console.WriteLine("иди работать");
}
else
Console.WriteLine("иди в первый класс, в неделе 7 дней");