namespace CsLabs;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        string buffer = Console.ReadLine();
        int age = Convert.ToInt32(buffer);
        Console.WriteLine("==Player's game passport==");
        Console.WriteLine($"Name: {name}");
        Console.Write($"Age: {age}");
    }
}
