Console.WriteLine("insert your name");
string username = Console.ReadLine();

if(username.ToLower() == "глеб") // tolower перевод все буквы в нижний регист и без разницы как написать "маша"
{
    Console.WriteLine("Ура, это же Глеб");
}
else
{
    Console.Write("FuckYou, ");
    Console.Write (username);
}