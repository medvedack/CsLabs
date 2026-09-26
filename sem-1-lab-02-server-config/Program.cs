namespace CsLabs;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество игроков на сервере: ");
        int playersCount = int.Parse(Console.ReadLine());

        Console.Write("Введите количество оперативной памяти: ");
        int memoryGb = int.Parse(Console.ReadLine());

        Console.Write("Сервер публичный? (Да/Нет): ");
        string bufferIsPublic = Console.ReadLine();
        bool isPublic = bufferIsPublic == "Да" || bufferIsPublic == "да";

        Console.Write("Сервер защищён паролем? (Да/Нет): ");
        string bufferHasPassword = Console.ReadLine();
        bool hasPassword = bufferHasPassword == "Да" || bufferHasPassword == "да";

        var result = CheckConfiguration(playersCount, memoryGb, isPublic, hasPassword);
        Console.WriteLine(result);
    }
    public static string CheckConfiguration(int playersCount, int memoryGb, bool isPublic, bool hasPassword)
    {
        if (playersCount == 0) return "Запуск невозможен: количество игроков должно быть больше нуля.";
        else if (memoryGb < 4) return "Запуск невозможен: серверу недостаточно оперативной памяти.";
        else if (isPublic && hasPassword) return "Запуск возможен с предупреждением: публичный сервер защищён паролем.";
        else if (playersCount > 50 && memoryGb < 8) return "Запуск возможен с предупреждением: для такого количества игроков рекомендуется больше оперативной памяти.";
        return "Сервер готов к запуску.";
    }
}
