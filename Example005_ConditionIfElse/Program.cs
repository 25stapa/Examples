Console.Write("Input name user: ");
string username = Console.ReadLine();

if(username.ToLower() == "olga")
{
    Console.WriteLine("Ура, это же Ольга!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username); 
}