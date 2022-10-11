Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "татьяна")
{
Console.WriteLine("Приветствую, моя госпожа ");
}
else
{
Console.Write("Привет, ");
Console.WriteLine(username);
}