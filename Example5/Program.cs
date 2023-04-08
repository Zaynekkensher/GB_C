Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "хуйло")
{
    Console.WriteLine("ЗДАРОВО ХУЙЛО!!!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
    Console.Write("!!!");
    }