Console.WriteLine("Введите ваше имя");
string username = Console.ReadLine();

if(username.ToLower() == "алеся")
{
    Console.WriteLine("Ура, это же Алеся");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}