Console.WriteLine("Enter your Name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hey! Its Maria!");
}
else
{
    Console.Write("Hello! ");
    Console.WriteLine(username);
}