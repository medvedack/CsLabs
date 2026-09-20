namespace CsLabs;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the server name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the count of active servers: ");
        byte activeServers = byte.Parse(Console.ReadLine());
        byte maxServers = 8;

        Console.Write("Enter the current online players count: ");
        int currentOnlineCount = int.Parse(Console.ReadLine());

        Console.Write("Enter RAM in use (GB): ");
        float usedRam = float.Parse(Console.ReadLine());
        float totalRam = 16.0f;

        Console.Write("Enter CPU temperature (°C): ");
        double cpuTemperature = double.Parse(Console.ReadLine());

        Console.Write("Is the server online? (true/false): ");
        bool isOnline = bool.Parse(Console.ReadLine());

        Console.WriteLine("==Server Information:==");
        Console.WriteLine($"Server Name: {name}");
        Console.WriteLine($"Active Servers: {activeServers}/{maxServers}");
        Console.WriteLine($"Current Online Count: {currentOnlineCount}");
        Console.WriteLine($"RAM Usage: {usedRam}/{totalRam} GB");
        Console.WriteLine($"CPU Temperature: {cpuTemperature} °C");
        Console.WriteLine($"Is Online: {isOnline}");

    }
}
