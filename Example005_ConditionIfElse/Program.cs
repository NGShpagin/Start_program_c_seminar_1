Console.Write("Enter username: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Yeah, hello, Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}