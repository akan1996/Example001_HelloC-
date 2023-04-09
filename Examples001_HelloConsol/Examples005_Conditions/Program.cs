Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "Ахан")
{
  Console.WriteLine("Ура это же АХАН!");
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(username);
}